﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestCreacionProyecto.Models;

namespace TestCreacionProyecto.Controllers
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
            //try
            //{
            //    int num = 0;
            //    int x = 9;
            //    int resp;
            //    resp = x/num;

            //    _logger.LogWarning("Este es un mensaje de advertencia");
            //}
            //catch (Exception ex)
            //{
            //    _logger.LogError($"Mensaje de Error:{ex.Message}");
            //}
        
            return View();
        }

        public IActionResult Privacy()
        {
            try
            {
                int num = 0;
                int x = 9;
                int resp;
                resp = x / num;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            

            return View();
        }

        

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View();
        //}
    }
}
