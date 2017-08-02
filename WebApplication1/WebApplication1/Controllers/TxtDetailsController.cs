using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;

namespace WebApplication1.Controllers
{
    public class TxtDetailsController : Controller
    {
        private IHostingEnvironment _env;
        public TxtDetailsController(IHostingEnvironment env)
        {
            _env = env;
        }

        public IActionResult Details(string fn)
        {
            ViewData["fn"] = fn;
            ViewData["content"] = System.IO.File.ReadAllText(fn);
            return View();
        }
    }
}