using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Services.Helpers;
using Services.Interfaces;
using ViewModels;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userSerivce;
        private readonly HttpClient _client;
        private readonly IOptions<AppSettings> _options;

        public HomeController(IUserService userSerice, IOptions<AppSettings> options)
        {
            _client = new HttpClient();
            _userSerivce = userSerice;
            _options = options;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult SaveExcel()
        {
            var users = _userSerivce.GetAll().ToList();
            var response =_client.PostAsJsonAsync(_options.Value.SaveExcelApi, users).Result;

            var status = (int)response.StatusCode;

            if (status >= 200 && status < 300)
            {
                return View();
            }
            return RedirectToAction("Error");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(ErrorViewModel model)
        {
            model.RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View(model);
        }
    }
}
