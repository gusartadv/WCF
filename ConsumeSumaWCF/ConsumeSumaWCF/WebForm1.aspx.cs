﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsumeSumaWCF
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        ServiceReference1.Service1Client sm = new ServiceReference1.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(TextBox1.Text);
            int num2 = Convert.ToInt32(TextBox2.Text);

            TextBox3.Text = Convert.ToString(sm.SumaDeEnteros(num1, num2));
        }
    }
}//este servicio funciona normalmente tiene q estar ejecutando el WcfSuma