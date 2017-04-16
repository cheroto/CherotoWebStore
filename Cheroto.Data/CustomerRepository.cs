using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cheroto.Domain;

namespace Cheroto.Data
{
    public class CustomerRepository
    {
        public List<Customer> GetCustomers()
        {
            var context = new CherotoContext();

            return context.Customers.ToList();
        }
    }
}
