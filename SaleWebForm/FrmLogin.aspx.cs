using System;
using System.Data;

namespace SaleWebForm
{
    public partial class FrmLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["UserID"] = null;
            Session["UserName"] = null;
            Session["FullName"] = null; 
            Session["Role"] = null;
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            string userName = TextBoxUserName.Text;
            string passWord = TextBoxPassWord.Text;
            string passWordEncode = Helpers.EncodePassWord(passWord);

            // Debug
            System.Diagnostics.Debug.WriteLine(userName);
            System.Diagnostics.Debug.WriteLine(passWordEncode);

            string query = $"select userId, fullName, email, userName, role from tblUser where userName = '{userName}' and passWord = '{passWordEncode}'";
            var dataReader = SqlHelpers.ExecuteReader(SqlHelpers.defaultConnStr, query, CommandType.Text);

            // Nếu đăng nhập thành công
            if (dataReader.HasRows)
            {
                dataReader.Read();
                Session["UserID"] = dataReader["userId"];
                Session["UserName"] = dataReader["userName"];
                Session["FullName"] = dataReader["fullName"];
                Session["Role"] = dataReader["role"];
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                SetFocus(TextBoxPassWord);
                Helpers.RenderAlerts(Helpers.AlertType.danger, LabelWarning, "Tên tài khoản hoặc mật khẩu không chính xác!");
            }
        }
    }
}