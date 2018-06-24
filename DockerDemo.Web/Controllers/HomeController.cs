using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DockerDemo.Web.Models;

namespace DockerDemo.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var isContainer = Convert.ToBoolean(Environment.GetEnvironmentVariable("IS_CONTAINER"));
            string messageFromApi = string.Empty;
            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://10.0.75.1:8000/api/values");
            if (response.IsSuccessStatusCode)
            {
                messageFromApi = await response.Content.ReadAsStringAsync();
            }

            var model = new HomeModel
            {
                MyId = Environment.MachineName,
                IsContainer = isContainer,
                MessageFromApi = messageFromApi
            };
            return View(model);
        }
    }
}
