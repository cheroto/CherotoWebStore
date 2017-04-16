using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cheroto.Data;

namespace Cheroto.Web
{
    public partial class ListProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var repository = new ProductRepository();
            var productList = repository.GetProducts();

            dgdProducts.DataSource = productList;
            dgdProducts.DataBind();
        }

        protected void dgdProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}