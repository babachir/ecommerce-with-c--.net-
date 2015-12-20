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

        public void CreateAdmin(string firstname, string lastname, string email, string password)
        {
            bdd.Admins.Add(new Admin { Firstname = firstname, Lastname = lastname, Email = email, Password = password });
            bdd.SaveChanges();
        }


        public void UpdateAdmin(int Id, string Firstname, string Lastname, string Email, string password)
        {
            Admin adminTomodif = bdd.Admins.FirstOrDefault(admin => admin.Id == Id);
            if(adminTomodif !=null)
            {
                adminTomodif.Firstname = Firstname;
                adminTomodif.Lastname = Lastname;
                adminTomodif.Email = Email;
                adminTomodif.Password = password;
                bdd.SaveChanges();
            }
        }

        public Admin Athentification(string email, string password)
        {
                
                return bdd.Admins.FirstOrDefault(admin => admin.Email == email && admin.Password == password);

        }

        public Admin GetAdminByid(int id)
        {
            Admin Adminreturned = bdd.Admins.FirstOrDefault(admin => admin.Id == id);
            if (Adminreturned != null)
            {
                return Adminreturned;
            }
            return null;

        }

        public void CreateShop(string address , string city , string zipcode , string country , string numphone, string  fax )
        {
            bdd.Shops.Add(new Shop { Address = address, City= city, Zipcode= zipcode, Country= country , Numphone = numphone, Fax = fax});
            bdd.SaveChanges();
        }
        public Shop GetShopById(int id)
        {
            Shop Shopreturned = bdd.Shops.FirstOrDefault(shop => shop.Id == id);
            if (Shopreturned!= null)
            {
                return Shopreturned;
            }
            return null;

        }

        public void UpdateShop(int id, string address, string city, string zipcode, string country, string numphone, string fax)
        {
            Shop shopUpdate = bdd.Shops.FirstOrDefault(shop => shop.Id == id);
            if (shopUpdate != null)
            {

                shopUpdate.Address= address ;
                shopUpdate.City=city ;
                shopUpdate.Country=country ;
                shopUpdate.Zipcode=zipcode ;
                shopUpdate.Numphone=numphone ;
                shopUpdate.Fax=fax ;
                bdd.SaveChanges();
            }

        }

        public void DeleteShop(Shop shop)
        {
            bdd.Shops.Remove(shop);
            bdd.SaveChanges();
        }
    }
}