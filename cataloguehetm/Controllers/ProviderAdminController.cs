using cataloguehetm.Models;
using cataloguehetm.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cataloguehetm.Controllers
{
    [Authorize]
    public class ProviderAdminController : Controller
    {
        private Dal dal = new Dal();
        // GET: ProviderAdmin
        public ActionResult Lists()
        {
            ProviderAdminListViewModel ViewModel = new ProviderAdminListViewModel();
            ViewModel.Provider = dal.GetAllProvider();
            return View(ViewModel);
        }
        public ActionResult Add()
        {
            ProviderViewModel ModelView = new ProviderViewModel();
            return View(ModelView);
        }
        [HttpPost]
        public ActionResult Add(ProviderViewModel providerViewModel)
        {

            dal.CreateProvider(providerViewModel.provider.Entreprise, providerViewModel.provider.Contact, providerViewModel.provider.Address, providerViewModel.provider.City, providerViewModel.provider.Zipcode, providerViewModel.provider.Country,
                providerViewModel.provider.Numphone, providerViewModel.provider.Fax);
            Response.Redirect("/ProviderAdmin/Lists");
            return View(providerViewModel);
        }
        public ActionResult Update(int id)
        {

            ProviderViewModel providerModelView = new ProviderViewModel { provider = dal.GetProviderById(id) };
            return View(providerModelView);
        }
        [HttpPost]
        public ActionResult Update(ProviderViewModel providerViewModel)
        {

            dal.UpdateProvider(providerViewModel.provider.Id,providerViewModel.provider.Entreprise,providerViewModel.provider.Contact
                ,providerViewModel.provider.Address,providerViewModel.provider.City,providerViewModel.provider.Zipcode,providerViewModel.provider.Country
                ,providerViewModel.provider.Numphone,providerViewModel.provider.Fax);
            Response.Redirect("/ProviderAdmin/Lists");
            return View(providerViewModel);
        }

        public ActionResult Delete(int id)
        {
            Provider provider = dal.GetProviderById(id);
            dal.DeleteProvider(provider);
            Response.Redirect("/ProviderAdmin/Lists");
            return View();
        }

    }
}