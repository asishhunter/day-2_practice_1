using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginPage
{
    public partial class SignIN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSI_Click(object sender, EventArgs e)
        {
            if (txtSi.Text == "admin" && txtPass.Text == "admin@123")
                Response.Redirect("Default.aspx");
            else
                Response.Write("Invalid Login Credentials!");
        }
    }
}