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
        private Dal dal = new Dal();
        // GET: ShopAdmin
        public ActionResult Lists()
        {

            ShopAdminListViewModel ViewModel = new ShopAdminListViewModel();
            ViewModel.Shops = dal.GetAllShop();
            return View(ViewModel);
        }
        public ActionResult Add()
        {
            ShopViewModel shopModelView = new ShopViewModel();
            return View(shopModelView);
        }
        [HttpPost]
        public ActionResult Add(ShopViewModel shopViewModel)
        {

            dal.CreateShop(shopViewModel.shop.Address, shopViewModel.shop.City, shopViewModel.shop.Zipcode, shopViewModel.shop.Country,
                shopViewModel.shop.Numphone, shopViewModel.shop.Fax);
            Response.Redirect("/ShopAdmin/Lists");
            return View(shopViewModel);
        }
        public ActionResult Update(int id)
        {
            
            ShopViewModel shopModelView = new ShopViewModel { shop = dal.GetShopById(id)};
            return View(shopModelView);
        }
        [HttpPost]
        public ActionResult Update(ShopViewModel shopViewModel)
        {

            dal.UpdateShop( shopViewModel.shop.Id ,shopViewModel.shop.Address, shopViewModel.shop.City, shopViewModel.shop.Zipcode, shopViewModel.shop.Country,
            shopViewModel.shop.Numphone, shopViewModel.shop.Fax);
            Response.Redirect("/ShopAdmin/Lists");
            return View(shopViewModel);
        }

        public ActionResult Delete(int id)
        {
            Shop shop = dal.GetShopById(id);
            dal.DeleteShop(shop);
            Response.Redirect("/ShopAdmin/Lists");
            return View();
        }


    }
}