using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace cataloguehetm
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
            name: "CatalogueOrArticle",
            url: "{controller}/index/{type}",
            defaults: new { controller = "Home", action = "Index", type = UrlParameter.Optional }
            );

            routes.MapRoute(
            name: "AddPanier",
            url: "panier/add/{id}/{qte}",
            defaults: new { controller = "Panier", action = "add", id = UrlParameter.Optional, qte = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
