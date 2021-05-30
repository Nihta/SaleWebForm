using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SaleWebForm
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                string html = @"<li class='nav-item'> <a class='nav-link' href='/FrmLogin' runat='server'>Đăng nhập</a> </li>";
                Literal1.Text = html;
            } else
            {
                string html = @"<li class='nav-item'> <a class='nav-link' href='/FrmLogin' runat='server'>Đăng xuất</a> </li>";
                Literal1.Text = html;
            }
        }
    }
}