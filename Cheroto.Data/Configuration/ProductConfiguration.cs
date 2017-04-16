using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Cheroto.Domain;

namespace Cheroto.Data.Configuration
{
    internal class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            ToTable("Products");
            HasKey(x => x.ProductID);
            Property(x => x.ProductName);
            Property(x => x.UnitPrice);
        }
    }
}
