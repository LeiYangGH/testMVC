using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using WebApplication1.Data;
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
            string dir = Path.Combine(webRoot,"../");
            ViewData["lstTxtFiles"] = Directory.GetFiles(dir,"*.json").Select(x => new TxtFile(x)).ToArray();
            return View();
        }
    }
}