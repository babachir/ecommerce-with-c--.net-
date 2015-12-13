using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cataloguehetm.Models
{
    public class Dal : IDal
    {
        private BddContext bdd;
        public Dal()
        {
            bdd = new BddContext();
        }

        public void CreateAdmin(string firstname, string lastname, string email, string password)
        {
            bdd.Admins.Add(new Admin { Firstname = firstname, Lastname = lastname,Email =email,Password = password});
            bdd.SaveChanges();
        }

        public void Dispose()
        {
            bdd.Dispose();
        }

        public List<Admin> GetAllAdmin()
        {
            return bdd.Admins.ToList();
        }

        public List<Article> GetAllArticle()
        {
            return bdd.Articles.ToList();
        }

        public List<Catalogue> GetAllCatalogue()
        {
            return bdd.Catalogues.ToList();
        }

        public List<Client> GetAllClient()
        {
            return bdd.Clients.ToList();
        }

        public List<Commande> GetAllCommande()
        {
            return bdd.Commandes.ToList();
        }

        public List<Provider> GetAllProvider()
        {
            return bdd.Providers.ToList();
        }

        public List<Shop> GetAllShop()
        {
            return bdd.Shops.ToList();
        }
    }
}