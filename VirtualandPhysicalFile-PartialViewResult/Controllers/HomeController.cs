using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VirtualandPhysicalFile_PartialViewResult.Models;

namespace VirtualandPhysicalFile_PartialViewResult.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _environment;

        public HomeController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public FileResult Download()
        {
            return File("/Files/FileResult.pdf", "text/plain", "FileResult.pdf");
        }
       
        public PhysicalFileResult PhysicalFileResult()
        {
            return new PhysicalFileResult(_environment.ContentRootPath + "/wwwroot/Files/PhysicalFileResult.pdf", "application/pdf");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
