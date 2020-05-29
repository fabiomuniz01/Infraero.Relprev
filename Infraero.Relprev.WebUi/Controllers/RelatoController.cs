using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Relato.Commands.CreateRelato;
using Infraero.Relprev.Application.Relato.Commands.CancelRelato;
using Infraero.Relprev.Application.Relato.Commands.UpdateRelato;
using Infraero.Relprev.Application.RelatoArquivo.Commands.CreateRelatoArquivo;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas;
using Infraero.Relprev.CrossCutting.Enumerators;
using Infraero.Relprev.CrossCutting.Filter;
using Infraero.Relprev.CrossCutting.Models;
using Infraero.Relprev.Domain.Entities;
using Infraero.Relprev.Infrastructure.Identity;
using Infraero.Relprev.WebUi.Authorization;
using Infraero.Relprev.WebUi.Factory;
using Infraero.Relprev.WebUi.Models;
using Infraero.Relprev.WebUi.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using Microsoft.Net.Http.Headers;
using Infraero.Relprev.Application.RelatoArquivo.Queries.GetRelatoArquivos;

namespace Infraero.Relprev.WebUi.Controllers
{
    [Authorize(Policy = ModuloAccess.Relatos)]
    public class RelatoController : Controller
    {
        private readonly IOptions<SettingsModel> _appSettings;
        private readonly IHostingEnvironment _hostingEnvironment;

        public RelatoController(IOptions<SettingsModel> app, IHostingEnvironment hostingEnvironment)
        {
            _appSettings = app;
            _hostingEnvironment = hostingEnvironment;
            ApplicationSettings.WebApiUrl = _appSettings.Value.WebApiBaseUrl;
        }

        [ClaimsAuthorize("Relatos", "Consultar")]
        public ActionResult Create()
        {

            var resultUnidade = ApiClientFactory.Instance.GetUnidadeInfraEstruturaAll();

            var model = new RelatoModel
            {
                ListUnidadeInfraestrutura = new SelectList(resultUnidade, "CodUnidadeInfraestrutura", "NomUnidadeÌnfraestrutura")
            };

            return View(model);
        }

        [HttpPost]
        public string UploadFile()
        {
            string result = string.Empty;

            try
            {

                long size = 0;

                var file = Request.Form.Files;

                var filename = ContentDispositionHeaderValue

                    .Parse(file[0].ContentDisposition)

                    .FileName

                    .Trim();

                string FilePath = _hostingEnvironment.WebRootPath + $@"\{ filename}";

                size += file[0].Length;

                using (FileStream fs = System.IO.File.Create(FilePath))
                {

                    file[0].CopyTo(fs);

                    fs.Flush();
                }



                result = FilePath;
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }

            return result;

        }


        [HttpPost]
        //[ValidateAntiForgeryToken]
        [ServiceFilter(typeof(ValidateReCaptchaAttribute))]
        public async Task<IActionResult> Create(IFormCollection collection)
        {
            try
            {
                string uniqueFileName = null;
                var listRelatoArquivo = new List<RelatoArquivoDto>();


                if (collection.Files.Count > 0)
                {
                    var file = collection.Files;

                    foreach (var item in file)
                    {

                        string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "RelatoArquivo");

                        string extension = Path.GetExtension(item.FileName);
                        uniqueFileName = Guid.NewGuid().ToString() + extension;
                        var realName = item.GetFilename();
                        string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                        item.CopyTo(new FileStream(filePath, FileMode.Create));

                        listRelatoArquivo.Add(new RelatoArquivoDto(uniqueFileName, realName, "RelatoArquivo"));
                    }

                }

                var command = new CreateRelatoCommand
                {
                    CodUnidadeInfraestrutura = int.Parse(collection["ddlUnidadeInfraestrutura"].ToString()),
                    DatOcorrencia = collection["DtOcorrencia"].ToString(),
                    HorOcorrencia = collection["HorOcorrencia"].ToString(),
                    DscEnvolvidosOcorrencia = collection["DscEnvolvidosOcorrencia"].ToString(),
                    DscLocalOcorrenciaRelator = collection["DscLocalOcorrenciaRelator"].ToString(),
                    DscOcorrenciaRelator = collection["DscOcorrenciaRelator"].ToString(),
                    DscRelato = collection["DscOcorrenciaRelator"].ToString(),
                    NomRelator = collection["NomRelator"].ToString(),
                    EmailRelator = collection["EmailRelator"].ToString(),
                    NumTelefoneRelator = collection["NumTelefoneRelator"].ToString(),
                    NomEmpresaRelator = collection["NomEmpresaRelator"].ToString(),
                    ListRelatoArquivo = listRelatoArquivo,
                    CriadoPor = User.Identity.Name
                };

                var idRelato = await ApiClientFactory.Instance.CreateRelato(command);

                return RedirectToAction(nameof(Index), new { crud = (int)EnumCrud.Created });
            }
            catch (Exception e)
            {
                var resultUnidade = ApiClientFactory.Instance.GetUnidadeInfraEstruturaAll();

                var model = new RelatoModel
                {
                    ListUnidadeInfraestrutura = new SelectList(resultUnidade, "CodUnidadeInfraestrutura", "NomUnidadeÌnfraestrutura"),

                };


                return View(model);
            }
        }

        public async Task<IActionResult> Cancel(IFormCollection collection)
        {
            try
            {

                var command = new CancelRelatoCommand
                {
                    CodRelato = 3,
                    DscMotivoCancelamento = collection["DscMotivoCancelamento"].ToString(),
                    AlteradoPor = User.Identity.Name,

                };

                await ApiClientFactory.Instance.CancelRelato(command);

                return RedirectToAction(nameof(Index), new { crud = (int)EnumCrud.Created });
            }
            catch (Exception e)
            {
                var resultUnidade = ApiClientFactory.Instance.GetUnidadeInfraEstruturaAll();

                var model = new RelatoModel
                {
                    ListUnidadeInfraestrutura = new SelectList(resultUnidade, "CodUnidadeInfraestrutura", "NomUnidadeÌnfraestrutura"),

                };


                return View(model);
            }
        }

        [Route("Infusao/Download/{filename}")]
        public async Task<IActionResult> Download(string filename)
        {
            if (filename == null)
                return Content("filename not present");

            var path = Path.Combine(
                Directory.GetCurrentDirectory(),
                "wwwroot\\RelatoArquivos", filename);

            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, GetContentType(path), Path.GetFileName(path));
        }

        private string GetContentType(string path)
        {
            var types = GetMimeTypes();
            var ext = Path.GetExtension(path).ToLowerInvariant();
            return types[ext];
        }

        private Dictionary<string, string> GetMimeTypes()
        {
            return new Dictionary<string, string>
            {
                {".txt", "text/plain"},
                {".pdf", "application/pdf"},
                {".doc", "application/vnd.ms-word"},
                {".docx", "application/vnd.ms-word"},
                {".xls", "application/vnd.ms-excel"},
                {".xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"},
                {".png", "image/png"},
                {".jpg", "image/jpeg"},
                {".jpeg", "image/jpeg"},
                {".gif", "image/gif"},
                {".csv", "text/csv"}
            };
        }

        public ActionResult Index()
        {
            var response = ApiClientFactory.Instance.GetGridRelato();
            return View(response);
        }

        public ActionResult Edit(int id)
        {
            var obj = ApiClientFactory.Instance.GetRelatoById(id);
            var resultUnidade = ApiClientFactory.Instance.GetUnidadeInfraEstruturaAll();
            var arquivos = ApiClientFactory.Instance.GetRelatoArquivoByIdRelato(obj.CodRelato);
            var model = new RelatoModel
            {
                Relato = obj,
                ListRelatoArquivo = arquivos,
                CodUnidadeInfraestrutura = obj.CodUnidadeInfraestrutura,
                ListUnidadeInfraestrutura = new SelectList(resultUnidade, "CodUnidadeInfraestrutura", "DscCodUnidadeDescricao", obj.CodUnidadeInfraestrutura.ToString()),

            };

            return View(model);

        }

        [HttpPost]
        public ActionResult Edit(int id, IFormCollection collection)
        {

            try
            {

                string uniqueFileName = null;
                var listRelatoArquivo = new List<RelatoArquivoDto>();


                if (collection.Files.Count > 0)
                {
                    var file = collection.Files;

                    foreach (var item in file)
                    {

                        string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "relatoRelatoArquivo");

                        string extension = Path.GetExtension(item.FileName);
                        uniqueFileName = Guid.NewGuid().ToString() + extension;
                        var realName = item.GetFilename();
                        string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                        item.CopyTo(new FileStream(filePath, FileMode.Create));

                        listRelatoArquivo.Add(new RelatoArquivoDto(uniqueFileName, realName, uploadsFolder));
                    }

                }
                var command = new UpdateRelatoCommand
                {
                    CodRelato = id,
                    AlteradoPor = User.Identity.Name,
                    CodUnidadeInfraestrutura = int.Parse(collection["ddlUnidadeInfraestrutura"].ToString()),
                    //DatOcorrencia = collection["DtOcorrencia"].ToString(),
                    //HorOcorrencia = collection["HorOcorrencia"].ToString(),
                    //DscEnvolvidosOcorrencia = collection["DscEnvolvidosOcorrencia"].ToString(),
                    //DscLocalOcorrenciaRelator = collection["DscLocalOcorrenciaRelator"].ToString(),
                    //DscOcorrenciaRelator = collection["DscOcorrenciaRelator"].ToString(),
                    DscRelato = collection["DscOcorrenciaRelator"].ToString(),
                    //NomRelator = collection["NomRelator"].ToString(),
                    //EmailRelator = collection["EmailRelator"].ToString(),
                    //NumTelefoneRelator = collection["NumTelefoneRelator"].ToString(),
                    //NomEmpresaRelator = collection["NomEmpresaRelator"].ToString(),
                    //ListRelatoArquivo = listRelatoArquivo,
                };
                ApiClientFactory.Instance.UpdateRelato(command);

                return RedirectToAction(nameof(Index), new { crud = (int)EnumCrud.Updated });
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Cancel(int id)
        {
            var obj = ApiClientFactory.Instance.GetRelatoById(id);
            var resultUnidade = ApiClientFactory.Instance.GetUnidadeInfraEstruturaAll();

            var model = new RelatoModel
            {
                Relato = obj,
                ListUnidadeInfraestrutura = new SelectList(resultUnidade, "CodUnidadeInfraestrutura", "DscCodUnidadeDescricao", obj.CodUnidadeInfraestrutura.ToString()),

            };

            return View(model);
        }

        public ActionResult Finalize()
        {
            return View();
        }
    }
}