using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cheroto.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<br/>");
            int i0 = Convert.ToInt32(txtNumber.Text);
            for (int i = i0; i < i0 + 10; i++)
            {
                sb = sb.Append(i.ToString() + "<br/>");
            }
            ltrHelloWorld.Text = sb.ToString();
        }
    }
}