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
    public class CatalogueAdminController : Controller
    {
        private Dal dal = new Dal();
        // GET: Catalogue
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Lists()
        {
            CatalogueAdminListViewModel ViewModel = new CatalogueAdminListViewModel();
            ViewModel.catalogue = dal.GetAllCatalogue();
            return View(ViewModel);
        }
        public ActionResult Add()
        {
            CatalogueViewModel ModelView = new CatalogueViewModel();
            List<Provider> Allprovider = dal.GetAllProvider();
            IEnumerable<Provider> item = Allprovider;
            ModelView.providers = Allprovider;
            ViewData["item"] = item;
            if (Request.HttpMethod == "POST")
            {
                Provider provider = dal.GetProviderById(Int32.Parse(Request.Form["ProviderId"]));
                
                dal.createCatalogue(Request.Form["catalogueName"], Request.Form["catalogueYear"],
                Request.Form["catalogueUrlimage"],provider);
                Response.Redirect("/CatalogueAdmin/Lists");
            }
            return View(ModelView);
        }

        //[HttpPost]
        /*public ActionResult Add(CatalogueViewModel catalogueViewModel)
        {
            /*
            Provider provider = dal.GetProviderById(catalogueViewModel.ProviderId);
            dal.createCatalogue
                (catalogueViewModel.catalogue.Name,
                catalogueViewModel.catalogue.Year,
                catalogueViewModel.catalogue.Urlimage,
                provider
                );
            Response.Redirect("/CatalogueAdmin/Lists");
            return View(catalogueViewModel);
        } */
        public ActionResult Update(int id)
        {

            ProviderViewModel providerModelView = new ProviderViewModel { provider = dal.GetProviderById(id) };
            return View(providerModelView);
        }
        [HttpPost]
        public ActionResult Update(ProviderViewModel providerViewModel)
        {

            dal.UpdateProvider(providerViewModel.provider.Id, providerViewModel.provider.Entreprise, providerViewModel.provider.Contact
                , providerViewModel.provider.Address, providerViewModel.provider.City, providerViewModel.provider.Zipcode, providerViewModel.provider.Country
                , providerViewModel.provider.Numphone, providerViewModel.provider.Fax);
            Response.Redirect("/ProviderAdmin/Lists");
            return View(providerViewModel);
        }

        public ActionResult Delete(int id)
        {
            Catalogue catalogue = dal.GetCatalogueById(id);
            dal.DeleteCatalogue(catalogue);
            Response.Redirect("/CatalogueAdmin/Lists");
            return View();
        }
    }
}