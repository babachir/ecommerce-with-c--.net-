using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cataloguehetm.Controllers
{
    [Authorize]
    public class CatalogueAdminController : Controller
    {
        // GET: Catalogue
        public ActionResult Index()
        {
            return View(); 
        }
    }
}