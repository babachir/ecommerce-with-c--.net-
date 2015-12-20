using cataloguehetm.Models;
using cataloguehetm.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace cataloguehetm.Controllers
{
    public class ShopAdminController : Controller
    {
        // GET: ShopAdmin
        public ActionResult Lists()
        {
            IDal dal = new Dal();
            ShopAdminListViewModel ViewModel = new ShopAdminListViewModel();
            ViewModel.Shops = dal.GetAllShop();
            return View(ViewModel);
        }
        public ActionResult Add()
        {
            return View();
        }


    }
}