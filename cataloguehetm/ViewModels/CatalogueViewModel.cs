using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cataloguehetm.ViewModels
{
    public class CatalogueViewModel
    {
        public Catalogue catalogue { get; set; }
        public int ProviderId { get; set; }
    }
}