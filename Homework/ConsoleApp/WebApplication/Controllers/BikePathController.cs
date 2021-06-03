using ConsoleApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;
using System.Diagnostics;

namespace WebApplication.Controllers
{
    public class BikePathController : Controller
    {

        public IActionResult Index()
        {

            var service = new ConsoleApp.Services.ImportJsonService();
            var filePath = ConsoleApp.Utils.FilePath.GetFullPath("自行車道.json");
            List<BikePath> datas = service.LoadFormFile(filePath);

            return View(datas);
        
        }

    }
}
