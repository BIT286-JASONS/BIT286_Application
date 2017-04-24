using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using BIT286_Application.Models;
using BIT286_Application.ViewModels;

namespace BIT286_Application.Controllers
{
    
    public class AccountController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ChangePassword()
        {
            return View();
        }
        public ActionResult Scores()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ChangePassword(NewPassword newpassword)
        {
            return View();
        }
    }
}