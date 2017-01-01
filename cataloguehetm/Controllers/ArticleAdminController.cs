using cataloguehetm.Models;
using cataloguehetm.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cataloguehetm.Controllers
{
    public class ArticleAdminController : Controller
    {

        private Dal dal = new Dal();
 
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Lists()
        {
            ArticleAdminListViewModel ViewModel = new ArticleAdminListViewModel();
            ViewModel.article = dal.GetAllArticle();
            return View(ViewModel);
        }
        public ActionResult Add()
        {
            ArticleViewModel ModelView = new ArticleViewModel();
            List<Catalogue> AllCatalogue = dal.GetAllCatalogue();
            IEnumerable<Catalogue> item = AllCatalogue;
            ModelView.catalogues = AllCatalogue;
            ViewData["item"] = item;
            if (Request.HttpMethod == "POST")
            {
                //Catalogue Catalogue = dal.GetCatalogueById(Int32.Parse(Request.Form["CatalogueId"]));

                dal.createArticle(
                    Request.Form["aricleName"],
                    float.Parse(Request.Form["articlePriceht"]), 
                    float.Parse(Request.Form["articleTva"]),
                    Int32.Parse(Request.Form["articleQtstock"]),
                    Request.Form["articleType"],
                    Request.Form["articleUrlimage"],
                    null
                    );
                Response.Redirect("/ArticleAdmin/Lists");
            }
            return View(ModelView);
        }

        public ActionResult Delete(int id)
        {
            Article article = dal.GetArticleById(id);
            dal.DeleteArticle(article);
            Response.Redirect("/ArticleAdmin/Lists");
            return View();
        }
    }
}