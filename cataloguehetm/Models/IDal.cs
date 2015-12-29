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
        void CreateProvider(string entreprise,string contact,string address, string city, string zipcode, string country, string numphone, string fax);
        void UpdateProvider(int id, string entreprise, string contact, string address, string city, string zipcode, string country, string numphone, string fax);
        Shop GetShopById(int id);
        void DeleteShop(Shop shop);
        Provider GetProviderById(int id);
        void DeleteProvider(Provider provider);
        void DeleteCatalogue(Catalogue catalogue);
        Catalogue GetCatalogueById(int id);
        void createCatalogue(string name, string year, string urlimage, Provider provider);
        void updateCatalogue(int i, string name, string year, string urlimage, Provider provider);
    }
}