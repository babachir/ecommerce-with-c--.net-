using cataloguehetm.Models;
using cataloguehetm.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cataloguehetm.Controllers
{
    public class ArticleController : Controller
    {
        private Dal dal = new Dal();
        // GET: Article
        public ActionResult Index(string type)
        {
            ArticleAdminListViewModel ViewModel = new ArticleAdminListViewModel();
            ViewModel.article = dal.GetArticleByType(type);
            return View(ViewModel);
        }
    }
}