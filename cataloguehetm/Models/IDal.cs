using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cataloguehetm.Models
{
    public interface IDal : IDisposable
    {
        List<Admin> GetAllAdmin();
        List<Article> GetAllArticle();
        List<Catalogue> GetAllCatalogue();
        List<Client> GetAllClient();
        List<Commande> GetAllCommande();
        List<Provider> GetAllProvider();
        List<Shop> GetAllShop();
        void CreateAdmin(string Firstname, string Lastname,string Email, string password);

    }
}