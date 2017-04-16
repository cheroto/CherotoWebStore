using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cheroto.Data;

namespace Cheroto.Web
{
    public partial class ListCustomers : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            var repository = new CustomerRepository();
            var customerList = repository.GetCustomers();

            dgdCustomers.DataSource = customerList;
            dgdCustomers.DataBind();
        }
    }
}