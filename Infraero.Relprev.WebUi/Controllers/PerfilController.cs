using Infraero.Relprev.Application.Perfil.Commands.CreatePerfil;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Claims;
using Infraero.Relprev.Application.Perfil.Commands.DeletePerfil;
using Infraero.Relprev.Application.Perfil.Commands.UpdatePerfil;
using Infraero.Relprev.CrossCutting.Enumerators;
using Infraero.Relprev.CrossCutting.Models;
using Infraero.Relprev.Infrastructure.Identity;
using Infraero.Relprev.WebUi.Authorization;
using Infraero.Relprev.WebUi.Factory;
using Infraero.Relprev.WebUi.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;
using ActionResult = Microsoft.AspNetCore.Mvc.ActionResult;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace Infraero.Relprev.WebUi.Controllers
{
    [Authorize(Policy = ModuloAccess.Cadastros)]
    public class PerfilController : BaseController
    {
        private readonly IOptions<SettingsModel> _appSettings;

        public PerfilController(IOptions<SettingsModel> app)
        {
            _appSettings = app;
            ApplicationSettings.WebApiUrl = _appSettings.Value.WebApiBaseUrl;
        }

        [ClaimsAuthorize("Perfil", "Consultar")]
        public ActionResult Index(int? crud)
        {
            SetCrudMessage(crud);
            var response = ApiClientFactory.Instance.GetGridPerfil();
            return View(response);
        }

        [ClaimsAuthorize("Perfil", "Incluir")]
        public ActionResult Create()
        {
            var responseModulos = ApiClientFactory.Instance.GetModuloAll();

            var model = new PerfilModel {ListModulo = responseModulos};
            return View(model);
        }

        [ClaimsAuthorize("Perfil", "Incluir")]
        [HttpPost]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                ListDictionary list = new ListDictionary();
                var responseModulos = ApiClientFactory.Instance.GetModuloAll();

                foreach (var modulo in responseModulos)
                {
                    var ListFuncionalidades = modulo.ListFuncionalidades.FirstOrDefault().NomFuncionalidade.Split(',');
                    var listValue = ListFuncionalidades
                        .Where(func => collection[modulo.NomModulo + func].ToString() == "on").ToList();
                    list.Add(modulo.NomModulo, string.Join(",", listValue));
                }

                var command = new CreatePerfilCommand
                {
                    NomPerfil = collection["NomPerfil"].ToString(),
                    ListClaim = list
                };

                ApiClientFactory.Instance.CreatePerfil(command);

                return RedirectToAction(nameof(Index), new {crud = (int) EnumCrud.Created});
            }
            catch (Exception e)
            {
                return View();
            }
        }

        [ClaimsAuthorize("Perfil", "Alterar")]
        public ActionResult Edit(string id)
        {
            var obj = ApiClientFactory.Instance.GetPerfilById(id);
            var responseModulos = ApiClientFactory.Instance.GetModuloAll();

            var listClaim = new List<Claim>();

            foreach (DictionaryEntry item in obj.ListClaims)
            {
                listClaim.Add(new Claim(item.Key.ToString(), item.Value.ToString()));
            }


            var model = new PerfilModel {Perfil = obj, ListModulo = responseModulos, ListClaim = listClaim};
            return View(model);
        }

        [ClaimsAuthorize("Perfil", "Alterar")]
        [HttpPost]
        public ActionResult Edit(string id, IFormCollection collection)
        {
            try
            {
                ListDictionary list = new ListDictionary();
                var responseModulos = ApiClientFactory.Instance.GetModuloAll();

                foreach (var modulo in responseModulos)
                {
                    var ListFuncionalidades = modulo.ListFuncionalidades.FirstOrDefault().NomFuncionalidade.Split(',');
                    var listValue = ListFuncionalidades
                        .Where(func => collection[modulo.NomModulo + func].ToString() == "on").ToList();
                    list.Add(modulo.NomModulo, string.Join(",", listValue));
                }

                var command = new UpdatePerfilCommand
                {
                    CodPerfil = id,
                    NomPerfil = collection["NomPerfil"].ToString(),
                    ListClaim = list
                };
                ApiClientFactory.Instance.UpdatePerfil(command);

                return RedirectToAction(nameof(Index), new {crud = (int) EnumCrud.Updated});
            }
            catch
            {
                return View();
            }
        }

        [ClaimsAuthorize("Perfil", "Excluir")]
        public ActionResult Delete(string id)
        {
            try
            {
                ApiClientFactory.Instance.DeletePerfil(new DeletePerfilCommand {CodPerfil = id, NomPerfilUsuarioPublico = UserRoles.UsuarioPublico});

                return RedirectToAction(nameof(Index), new {crud = (int) EnumCrud.Deleted});
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }
    }
}