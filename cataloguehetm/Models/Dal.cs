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

        public void CreateProvider(string entreprise, string contact, string address, string city, string zipcode, string country, string numphone, string fax)
        {
            bdd.Providers.Add(new Provider { Entreprise = entreprise, Contact = contact, Address = address, City= city,
                Zipcode = zipcode, Country=country, Numphone = numphone ,Fax = fax});
            bdd.SaveChanges();
        }

        public void UpdateProvider(int id, string entreprise, string contact, string address, string city, string zipcode, string country, string numphone, string fax)
        {
            Provider providerUpdate = bdd.Providers.FirstOrDefault(provider => provider.Id == id);
            if (providerUpdate != null)
            {
                providerUpdate.Entreprise = entreprise;
                providerUpdate.Contact = contact;
                providerUpdate.Address = address;
                providerUpdate.City = city;
                providerUpdate.Country = country;
                providerUpdate.Zipcode = zipcode;
                providerUpdate.Numphone = numphone;
                providerUpdate.Fax = fax;
                bdd.SaveChanges();
            }
        }

        public Provider GetProviderById(int id)
        {
            Provider providerreturned = bdd.Providers.FirstOrDefault(provider => provider.Id == id);
            if (providerreturned != null)
            {
                return providerreturned;
            }
            return null;
        }

        public void DeleteProvider(Provider provider)
        {
            bdd.Providers.Remove(provider);
            bdd.SaveChanges();
        }

        public void DeleteCatalogue(Catalogue catalogue)
        {
            bdd.Catalogues.Remove(catalogue);
            bdd.SaveChanges();
        }

        public Catalogue GetCatalogueById(int id)
        {
            Catalogue cataloguereturned = bdd.Catalogues.FirstOrDefault(catalogue => catalogue.Id == id);
            if (cataloguereturned != null)
            {
                return cataloguereturned;
            }
            return null;
        }



        public void updateCatalogue(int id, string name, string year, string urlimage, Provider provider)
        {
            Catalogue catalogueUpdate = bdd.Catalogues.FirstOrDefault(catalogue => catalogue.Id == id);
            if (catalogueUpdate != null)
            {
                catalogueUpdate.Name = name;
                catalogueUpdate.Year = year;
                catalogueUpdate.Urlimage = urlimage;
                catalogueUpdate.Provider = provider;
                bdd.SaveChanges();
            }
        }

        public void createArticle(string name, float priceht, float tva, int qtstock,string type, string urlImage, string codeVideo , Catalogue catalogue)
        {
            bdd.Articles.Add(new Article
            {
                Name = name,
                Priceht = priceht,
                Tva = tva,
                Qtstock = qtstock,
                Type = type,
                Urlimage = urlImage,
                Catalogue = catalogue,
                CodeVideo = codeVideo,
                poids =  0
            });
            bdd.SaveChanges();
        }

        public void DeleteArticle(Article article)
        {
            bdd.Articles.Remove(article);
            bdd.SaveChanges();
        }
        public void incrementePoids(int Id )
        {
            Article article = bdd.Articles.FirstOrDefault(a => a.Id == Id);
            if (article != null)
            {
                article.poids += 1;
                bdd.SaveChanges();
            }
        }

        public void createCatalogue(string name, string year,  string urlimage, Provider provider)
        {
            bdd.Catalogues.Add(new Catalogue
            {
                Name = name,
                Year = year,
                Urlimage = urlimage,
                Provider = provider


            });
            bdd.SaveChanges();
        }

        public Article GetArticleById(int id)
        {
            Article articlereturned = bdd.Articles.FirstOrDefault(article => article.Id == id);
            if (articlereturned != null)
            {
                return articlereturned;
            }
            return null;
        }

        public List<Article> GetArticleByType(string type)
        {
            List<Article> articlesreturned = bdd.Articles.Where(article => article.Type == type).ToList();
            if (articlesreturned != null)
            {
                return articlesreturned;
            }
            return null;
        }

        public List<Article> GetBestArticle()
        {
            List<Article> articlesreturned = bdd.Articles.OrderByDescending(a => a.poids).Take(3).ToList();
            if (articlesreturned != null)
            {
                return articlesreturned;
            }
            return null;
        }

        public void CreateCommande(string firstname, string lastname, string email, int qte, string address, string numcarde, string cvv, Article article)
        {
            bdd.Commandes.Add(new Commande
            {
                Firstname = firstname,
                Lastname = lastname,
                Email = email,
                Quantity = qte,
                Address = address,
                Numcard = numcarde,
                Cvv = cvv,
                Article = article

            });
            bdd.SaveChanges();

        }
    }
}