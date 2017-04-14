using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cheroto.Core;

namespace Cheroto.Web
{
    public partial class Validator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnValidate_Click(object sender, EventArgs e)
        {
            VerificationDigitCalculator vd = new VerificationDigitCalculator();
            ltrIsValid.Text = vd.CalculateVerificationDigit(txtRG.Text);
        }
    }
}