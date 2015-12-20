using cataloguehetm.Models;
using cataloguehetm.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace cataloguehetm.Controllers
{
    public class LoginController : Controller
    {
        private IDal dal = new Dal();
        // GET: Login
        public ActionResult Index()
        {
            IDal dal = new Dal();
            AdminViewModel adminViewModel = new AdminViewModel { authenticated = HttpContext.User.Identity.IsAuthenticated };
            if(HttpContext.User.Identity.IsAuthenticated)
            {
                adminViewModel.admin = dal.GetAdminByid(Int32.Parse(HttpContext.User.Identity.Name));
            }
            return View(adminViewModel);
        }

        [HttpPost]
        public ActionResult Index( AdminViewModel ViewModel, string returnUrl)
        {
            IDal dal = new Dal();

  
                Admin admin = dal.Athentification(ViewModel.admin.Email, ViewModel.admin.Password);
                if(admin != null)
                {
                    FormsAuthentication.SetAuthCookie(admin.Id.ToString(),false);
                    if (!string.IsNullOrWhiteSpace(returnUrl) && Url.IsLocalUrl(returnUrl))
                    {
                    Response.Redirect(returnUrl);
                    }
                    else
                    Response.Redirect("/");
                }
                
            
            return View(ViewModel);
        }

        public ActionResult Deconnexion()
        {
            FormsAuthentication.SignOut();
            return Redirect("/");
        }

    }
}