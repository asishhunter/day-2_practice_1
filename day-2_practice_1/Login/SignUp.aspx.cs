using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginPage
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSU_Click(object sender, EventArgs e)
        {
            if (txtUserIDReg.Text != "admin")
                Response.Redirect("SignIN.aspx");
            else
                Response.Write("This user name is not available.");
        }
    }
}