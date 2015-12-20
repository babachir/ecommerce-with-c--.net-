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
        void UpdateAdmin(int Id, string Firstname, string Lastname, string Email, string password);
        Admin Athentification( string email, string password );
        Admin GetAdminByid(int id);
        void CreateShop(string address, string city, string zipcode, string country, string numphone, string fax);
        void UpdateShop(int id, string address, string city, string zipcode, string country, string numphone, string fax);
        Shop GetShopById(int id);
        void DeleteShop(Shop shop);
    }
}