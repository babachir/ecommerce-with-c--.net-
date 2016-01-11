using cataloguehetm.Models;
using cataloguehetm.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cataloguehetm.Controllers
{
    public class PanierController : Controller
    {
        private Dal dal = new Dal();
        // GET: Panier
        public ActionResult Index()
        {

            PanierViewModel ViewModel = new PanierViewModel();
            List<ArticlePanier> ArticleInPanier = new List<ArticlePanier>();
            if (Session["listQtePanier"] != null)
            {
                ArticleInPanier = (List<ArticlePanier>)Session["listQtePanier"];
                ViewModel.articleP = ArticleInPanier;
                
            }
            else
            {
                ViewModel.articleP = null;
            }
            return View(ViewModel);
        }

        public bool vider()
        {

            Session["listQtePanier"] = null;
            Session["nbrArticle"] = null;
            Response.Redirect("/Panier");
            return true;
        }

        public ActionResult formAdd(int id)
        {
            ViewData["id"] = id;
            if (Request.HttpMethod == "POST")
            {
                Response.Redirect("/panier/add/"+id+"/"+ Request.Form["qte"]);
            }

                return View();
        }

        public ActionResult add(int id,int qte)
        {



      
            List<ArticlePanier> ArticleInPanier = new List<ArticlePanier>();
            if (Session["listQtePanier"] == null)
            {

  
                Session["listQtePanier"] = ArticleInPanier;

            }
            if (Session["nbrArticle"] == null)
            {

                Session["nbrArticle"] = qte;
            }
            else
            {
                Session["nbrArticle"] = (int)Session["nbrArticle"] + qte;
            }  

                ArticleInPanier = (List<ArticlePanier>)Session["listQtePanier"];
                ArticlePanier idAndQte = new ArticlePanier();
                idAndQte.IdArticle = id;
                idAndQte.nbr = qte;
                idAndQte.article = dal.GetArticleById(id);
                ArticleInPanier.Add(idAndQte);
         
                Session["listQtePanier"] = ArticleInPanier;

                Article articlePanier = new Article();
                articlePanier = dal.GetArticleById(id);


            



            Response.Redirect("/");
            return View();
        }

        public ActionResult Valider()
        {
            if (Request.HttpMethod == "POST")
            {
                List<ArticlePanier> ArticleInPanier = new List<ArticlePanier>();
                ArticleInPanier = (List<ArticlePanier>)Session["listQtePanier"];
                
                foreach (ArticlePanier ArticleP in ArticleInPanier)
                {

                    dal.CreateCommande(Request.Form["firstname"],
                        Request.Form["lastname"],
                        Request.Form["email"],
                        ArticleP.nbr,
                        Request.Form["address"],
                        Request.Form["numcarte"],
                        Request.Form["cvv"],
                        ArticleP.article

                        );
                }
                Response.Redirect("/panier/vider");
            }
            return View();
            
        }

    }
}