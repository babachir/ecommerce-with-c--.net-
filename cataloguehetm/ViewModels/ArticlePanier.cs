using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cataloguehetm.ViewModels
{
    public class ArticlePanier
    {
        public int IdArticle { get; set; }
        public int nbr { get; set; }
        public Article article { get; set; }
    }
}