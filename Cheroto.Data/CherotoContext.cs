using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Cheroto.Data.Configuration;
using Cheroto.Domain;

namespace Cheroto.Data
{
    public class CherotoContext : DbContext
    {
        public IDbSet<Product> Products { get; set; }
        public CherotoContext():base("Data Source=.;Initial Catalog=Northwind;Integrated Security=True;MultipleActiveResultSets=True")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
