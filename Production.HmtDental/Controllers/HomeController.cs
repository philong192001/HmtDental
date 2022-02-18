using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Production.HmtDental.Context;
using Production.HmtDental.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Production.HmtDental.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HmtContext _context;

        public HomeController(ILogger<HomeController> logger,HmtContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var listUser = _context.Users.ToList();
            return View(listUser);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
