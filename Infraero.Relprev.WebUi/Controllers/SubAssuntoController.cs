using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infraero.Relprev.Application.SubAssunto.Commands.CreateSubAssunto;
using Infraero.Relprev.Application.SubAssunto.Commands.UpdateSubAssunto;
using Infraero.Relprev.Application.SubAssunto.Queries.GetSubAssuntos;
using Infraero.Relprev.CrossCutting.Models;
using Infraero.Relprev.Domain.Entities;
using Infraero.Relprev.HttpClient.Clients.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ActionResult = Microsoft.AspNetCore.Mvc.ActionResult;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace Infraero.Relprev.WebUi.Controllers
{
    public class SubAssuntoController : Controller
    {
        private readonly ISubAssuntoClient _subAssuntoClient;
        private readonly IAssuntoClient _assuntoClient;

        public SubAssuntoController(ISubAssuntoClient subAssuntoClient, IAssuntoClient assuntoClient)
        {
            _subAssuntoClient = subAssuntoClient;
            _assuntoClient = assuntoClient;
        }

        //private readonly ISubAssunto 
        public IActionResult Index()
        {
            var response = _subAssuntoClient.GetGridSubAssunto();
            return View(response);
        }

        public GridSubAssunto GetGrid()
        {
            var response = _subAssuntoClient.GetGridSubAssunto();
            return response;
        }

        // GET: SubAssunto/Create
        public ActionResult Create()
        {
            var result = _assuntoClient.GetAssuntoAll();
            var listAssunto =
                result.Select(
                    s =>
                        new SelectListItem()
                        {
                            Text =
                                s.CodAssunto + " - " +
                                s.DscAssunto,
                            Value = s.CodAssunto.ToString()
                        }).ToList();

            var assunto = new SubAssuntoModel
            {
                ListAssunto = listAssunto
            };

            return View(assunto);
        }

        // POST: SubAssunto/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var command = new CreateSubAssuntoCommand
                {
                    CodAssunto = int.Parse(collection["CodAssunto"].ToString()),
                    DscSubAssunto = collection["DscSubAssunto"].ToString(),
                    CriadoPor = "Amcom Develper"
                };
                _subAssuntoClient.CreateSubAssunto(command);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: SubAssunto/Edit/5
        public ActionResult Edit(int id)
        {
            var obj = _subAssuntoClient.GetSubAssuntoById(id);
            var result = _assuntoClient.GetAssuntoAll();
            var listAssunto =
                result.Select(
                    s =>
                        new SelectListItem()
                        {
                            Text =
                                s.CodAssunto + " - " +
                                s.DscAssunto,
                            Value = s.CodAssunto.ToString()
                        }).ToList();

            var assunto = new SubAssuntoModel
            {
                SubAssunto = obj,
                ListAssunto = listAssunto
            };

            return View(assunto);
        }

        // POST: SubAssunto/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var command = new UpdateSubAssuntoCommand
                {
                    CodSubAssunto = id,
                    DscSubAssunto = collection["DscSubAssunto"].ToString(),
                    AlteradoPor = "Amcom Developer"
                };
                _subAssuntoClient.UpdateSubAssunto(command);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: SubAssunto/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                _subAssuntoClient.DeleteSubAssunto(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }
    }
}