using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Production.HmtDental.Common;
using Production.HmtDental.Context;
using Production.HmtDental.Models;
using System;
using System.Linq;

namespace Production.HmtDental.Controllers
{
    public class AccountController :Controller
    {
        private readonly HmtContext _hmtContext;
        private readonly ILogger<HomeController> _logger;
        private readonly HashKey _hashkey;
        public AccountController(ILogger<HomeController> logger,HmtContext hmtContext,HashKey hashKey)
        {
            _logger = logger;
            _hmtContext = hmtContext;
            _hashkey = hashKey;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost,ValidateAntiForgeryToken]
        public IActionResult Login(User user)
        {
            string _name = Request.Form["name"];
            string _password = Request.Form["pass"];

            if (!string.IsNullOrEmpty(_password))
            {
                //ma hoa password
                _password = _hashkey.ComputeSha256Hash(_password);
                //lay mot ban ghi
                var record = (from tbl in _hmtContext.Users where tbl.UserName == _name && tbl.Password == _password select tbl).FirstOrDefault();
                if (record != null)
                {
                     HttpContext.Session.SetString("name", _name);
                    //di chuyen den Url /Admin/Home
                    //return RedirectToAction("Index", "Home");                    
                    return RedirectToAction("Home", "Admin");
                }
            }
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            string _name = Request.Form["name"];
            string _password = Request.Form["pass"];
            string _repassword = Request.Form["repass"];
            int _phone = Int32.Parse(Request.Form["phone"]);

            if (_password == _repassword)
            {
                var record = new User();
                record.UserName = _name;
                record.Password = _hashkey.ComputeSha256Hash(_password);
                record.Phone = _phone;

                _hmtContext.Users.Add(record);
                _hmtContext.SaveChanges();

                return RedirectToAction("Home", "Admin");
            }
            else
            {
                ViewBag.Message = "Mật khẩu và mật khẩu nhập lại không khớp nhau";
                return View();
            }
        }

        public IActionResult Logout()
        {
            //huy tat ca cac session
            HttpContext.Session.Remove("name");
            //di chuyen den view login
            //return View("Index");
            return RedirectToAction("Login", "Account");
        }
    }
}
