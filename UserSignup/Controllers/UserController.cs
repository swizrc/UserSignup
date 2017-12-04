using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserSignup.Models;

namespace UserSignup.Controllers
{
    public class UserController : Controller
    {
        static string name = "Default";

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            ViewBag.name = name;
            return View();
        }

        [HttpPost]
        public IActionResult Add(User user, string verify)
        {

            if (user == null)
            {
                name = "DIDNT WORK";
                ViewBag.name = name;
            }
            else
            {
                name = "WORKED";
                ViewBag.name = name;
                ViewBag.email = user.password;
            }
            if (user.password != verify)
            {

                return View();
            }
            else
            {
                return Redirect("/User");
            }
            
        }
    }
}