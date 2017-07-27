using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace WebApplication1.Controllers
{
    public class TxtController : Controller
    {
        private IHostingEnvironment _env;
        public TxtController(IHostingEnvironment env)
        {
            _env = env;
        }
        public IActionResult Index()
        {
            var webRoot = _env.WebRootPath;
            //string dir = Server.MapPath(@"~/Data");
            string dir = Path.Combine(webRoot, @"../Data");
            ViewData["lstFileNames"] = Directory.GetFiles(dir);
            return View();
        }
    }
}