﻿using System;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Usuario.Commands.CreateUsuario;
using Infraero.Relprev.Application.Usuario.Commands.UpdateUsuario;
using Infraero.Relprev.Application.Usuario.Queries.GetUsuarios;
using Infraero.Relprev.HttpClient.Clients.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ActionResult = Microsoft.AspNetCore.Mvc.ActionResult;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace Infraero.Relprev.WebUi.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioClient _UsuarioClient;

        public UsuarioController(IUsuarioClient UsuarioClient)
        {
            _UsuarioClient = UsuarioClient;
        }

        //private readonly IUsuario 
        public IActionResult Index()
        {
            var response = _UsuarioClient.GetGridUsuario();
            return View(response);
        }

        public GridUsuario GetGrid()
        {
            var response = _UsuarioClient.GetGridUsuario();
            return response;
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var command = new CreateUsuarioCommand
                {
                    NomUsuario = collection["Usuario"].ToString(),
                    CriadoPor = "",
                    NumCpf = collection["cnpj"].ToString(),
                    NumTelefone = collection["telefone"].ToString()
                };
                _UsuarioClient.CreateUsuario(command);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            var obj = _UsuarioClient.GetUsuarioById(id);
            return View(obj);
        }

        // POST: Usuario/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var command = new UpdateUsuarioCommand
                {
                    Id = id,
                    NomUsuario = collection["Usuario"].ToString(),
                    AlteradoPor = "",
                    NumCpf = collection["cnpj"].ToString(),
                    NumTelefone = collection["telefone"].ToString()
                };
                _UsuarioClient.UpdateUsuario(command);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: Usuario/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                _UsuarioClient.DeleteUsuario(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }
    }
}