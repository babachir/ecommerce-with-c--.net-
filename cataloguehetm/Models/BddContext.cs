using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace cataloguehetm.Models
{
    public class BddContext : DbContext
    {
        public BddContext()
        {
            Database.SetInitializer<BddContext>(null);
        }
        public DbSet<Admin> Admins { get; set; } 
        public DbSet<Article> Articles { get; set; }
        public DbSet<Catalogue> Catalogues { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Shop> Shops { get; set; }

    }
}