using cataloguehetm.Models;
using cataloguehetm.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cataloguehetm.Controllers
{
    public class CatalogueController : Controller
    {
        private Dal dal = new Dal();
        // GET: Catalogue
        public ActionResult Index(string type)
        {
            CatalogueAdminListViewModel ViewModel = new CatalogueAdminListViewModel();
            ViewModel.catalogue = dal.GetAllCatalogue();
            ViewData["type"] = type;
            return View(ViewModel);
           
        }
    }
}