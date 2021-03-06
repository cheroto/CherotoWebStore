﻿using System;
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

        
        protected void btnValidateRG_Click(object sender, EventArgs e)
        {
            RGVerificationDigitCalculator vd = new RGVerificationDigitCalculator();
            ltrIsValidRG.Text = vd.CalculateVerificationDigit(txtRG.Text);
        }

        protected void btnValidateCPF_Click(object sender, EventArgs e)
        {
            CPFVerificationDigitCalculator vd = new CPFVerificationDigitCalculator();
            ltrIsValidCPF.Text = vd.CalculateVerificationDigit(txtCPF.Text);
        }
    }
}