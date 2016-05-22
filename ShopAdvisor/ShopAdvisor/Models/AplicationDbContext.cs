using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShopAdvisor.Models
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Place> Places { set; get; }

        public static AplicationDbContext Create ()
        {
            return new AplicationDbContext();
        }
    }
}