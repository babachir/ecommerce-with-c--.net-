using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cataloguehetm.ViewModels
{
    public class ArticleViewModel
    {
        public Article article { get; set; }
        public List<Catalogue> catalogues { get; set; }
    }
}