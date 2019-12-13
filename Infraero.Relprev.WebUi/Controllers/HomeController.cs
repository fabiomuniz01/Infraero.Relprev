using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Infraero.Relprev.CrossCutting.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Infraero.Relprev.WebUi.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Infraero.Relprev.WebUi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RecuperarSenha()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(IFormCollection collection)
        {
            try
            {
                //Hosted web API REST Service base url  
                string Baseurl = "https://localhost:44372/";
                var obj = new LoginUsuarioVm
                {
                    Email = collection["usuario"].ToString(),
                    Password = collection["password"].ToString()
                };
                //Passing service base url  
                using var client = new System.Net.Http.HttpClient {BaseAddress = new Uri(Baseurl)};
                
                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpContent c = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");

                //Sending request to find web api REST service resource  using HttpClient  
                HttpResponseMessage Res = await client.PostAsync(new Uri(Baseurl+"api/auth/login"), c);

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var response = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    //var teste = JsonConvert.DeserializeObject<LoginUsuarioVm>(response);

                    //returning the employee list to view  
                    return RedirectToAction("Index", "Dashboard");
                }

                return RedirectToAction(nameof(Index));

            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }

            return null;
        }










        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
