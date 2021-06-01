using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SaleWebForm
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                Response.Redirect("Frmlogin.aspx");
            }

            // Nếu không phải admin
            if (Session["Role"].ToString() != "1")
            {
                Response.Redirect("~/403.html");
            }
        }
    }
}