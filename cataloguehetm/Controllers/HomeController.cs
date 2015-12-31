using cataloguehetm.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace cataloguehetm.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        public ActionResult Index()
        {
            IDal dal = new Dal();
            //IDatabaseInitializer<BddContext> init = new DropCreateDatabaseAlways<BddContext>();
            //Database.SetInitializer(init);
            //init.InitializeDatabase(new BddContext());

          //  dal.CreateAdmin("bachir", "boumessaoud", "ba.bachir@hotmail.fr", "asbk1992");
            //Admin admin = dal.Athentification("ba.bachir@hotmail.fr","azerty123");
            //ViewData["nom"] = admin.Password;
            return View();
        }
    }
}