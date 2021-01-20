using Infraero.Relprev.Application.ConfigurarAmbiente.Commands.CreateConfigurarAmbiente;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using Infraero.Relprev.Application.ConfigurarAmbiente.Commands.UpdateConfigurarAmbiente;
using Infraero.Relprev.Application.ConfigurarAmbiente.Queries.GetConfigurarAmbientes;
using Infraero.Relprev.CrossCutting.Enumerators;
using Infraero.Relprev.CrossCutting.Models;
using Infraero.Relprev.Infrastructure.Identity;
using Infraero.Relprev.WebUi.Authorization;
using Infraero.Relprev.WebUi.Factory;
using Infraero.Relprev.WebUi.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using ActionResult = Microsoft.AspNetCore.Mvc.ActionResult;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace Infraero.Relprev.WebUi.Controllers
{
    [Authorize(Policy = ModuloAccess.ConfigurarAmbiente)]
    public class ConfigurarAmbienteController : BaseController
    {
        private readonly IOptions<SettingsModel> _appSettings;

        public ConfigurarAmbienteController(IOptions<SettingsModel> app)
        {
            _appSettings = app;
            ApplicationSettings.WebApiUrl = _appSettings.Value.WebApiBaseUrl;
        }

        [ClaimsAuthorize("ConfigurarAmbiente", "Consultar")]
        public ActionResult Index(int? crud)
        {
            SetCrudMessage(crud);
            var response = ApiClientFactory.Instance.GetConfigurarAmbienteAll().FirstOrDefault();
            var result = response == null ? new ConfigurarAmbienteDto() : response;
            return View(result);
        }


        [ClaimsAuthorize("ConfigurarAmbiente", "Incluir")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var conf = ApiClientFactory.Instance.GetConfigurarAmbienteAll().FirstOrDefault();
                if (conf!=null)
                {
                    var command = new UpdateConfigurarAmbienteCommand
                    {
                        CodConfigurarAmbiente = conf.CodConfigurarAmbiente,
                        ParecerTecnico = int.Parse(collection["ParecerTecnico"].ToString()),
                        DevolvidoParaComplemento = int.Parse(collection["DevolvidoParaComplemento"].ToString()),
                        TempoNotificacaoParaResponder = int.Parse(collection["TempoNotificacaoParaResponder"].ToString()),
                        TextoMotivoCancelamento = collection["TextoMotivoCancelamento"].ToString(),
                        AlteradoPor = User.Identity.Name
                    };
                    ApiClientFactory.Instance.UpdateConfigurarAmbiente(command);

                    return RedirectToAction(nameof(Index), new { crud = (int)EnumCrud.Updated });

                }
                else
                {

                    var command = new CreateConfigurarAmbienteCommand
                    {
                        ParecerTecnico = int.Parse(collection["ParecerTecnico"].ToString()),
                        DevolvidoParaComplemento = int.Parse(collection["DevolvidoParaComplemento"].ToString()),
                        TempoNotificacaoParaResponder =
                            int.Parse(collection["TempoNotificacaoParaResponder"].ToString()),
                        TextoMotivoCancelamento = collection["TextoMotivoCancelamento"].ToString(),
                        CriadoPor = User.Identity.Name
                    };
                    ApiClientFactory.Instance.CreateConfigurarAmbiente(command);

                    return RedirectToAction(nameof(Index), new { crud = (int)EnumCrud.Created });

                }

            }
            catch (Exception e)
            {
                return View();
            }
        }

        
        [ClaimsAuthorize("ConfigurarAmbiente", "Alterar")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var command = new UpdateConfigurarAmbienteCommand
                {
                    CodConfigurarAmbiente = id,
                    ParecerTecnico = int.Parse(collection["ParecerTecnico"].ToString()),
                    DevolvidoParaComplemento = int.Parse(collection["DevolvidoParaComplemento"].ToString()),
                    TempoNotificacaoParaResponder = int.Parse(collection["TempoNotificacaoParaResponder"].ToString()),
                    TextoMotivoCancelamento = collection["TextoMotivoCancelamento"].ToString(),
                    AlteradoPor = User.Identity.Name
                };
                ApiClientFactory.Instance.UpdateConfigurarAmbiente(command);

                return RedirectToAction(nameof(Index), new { crud = (int)EnumCrud.Updated });
            }
            catch
            {
                return View();
            }
        }
    }
}