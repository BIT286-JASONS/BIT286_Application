using BIT286_Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BIT286_Application.Models;

namespace BIT286_Application.Controllers
{
    public class LoginController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext(); 

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index(Login newLogin)
        {
            bool isUser = db.Users.Any(m => m.UserName == newLogin.UserName) && db.Users.Any(m => m.Password == newLogin.Password);

            if (isUser)
            {
                return View("Account/Index");
            }

            else
            {
                newLogin.ErrorMessage = "Invalid Input";
                return View("Login", newLogin);
            }
        }
    }
}