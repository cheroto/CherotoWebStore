using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cheroto.Domain;


namespace Cheroto.Data
{
    public class ProductRepository
    {
        public List<Product> GetProducts()
        {
            var context = new CherotoContext();

            return context.Products.ToList();
        }
    }
}
