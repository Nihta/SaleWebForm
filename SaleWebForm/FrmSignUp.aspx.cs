using System;

namespace SaleWebForm
{
    public partial class FrmSignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private bool isValid(string fullName, string userName, string passWord, string passRepeat)
        {
            LabelWarning.Text = "";
            if (Validation.IsTextInvalid(LabelWarning, fullName, 5, 24, "Họ và tên"))
            {
                if (Validation.IsTextInvalid(LabelWarning, userName, 5, 20, "Tên đăng nhập"))
                {
                    if (Validation.IsTextInvalid(LabelWarning, passWord, 3, 20, "Mật khẩu"))
                    {
                        if (passWord == passRepeat)
                        {
                            return true;
                        }
                        else
                        {
                            Helpers.RenderAlerts(Helpers.AlertType.warning, LabelWarning, $"Mật khẩu không khớp!");
                        }
                    }
                    else
                    {
                        SetFocus(TextBoxPassWord);
                    }
                }
                else
                {
                    SetFocus(TextBoxUserName);
                }
            }
            else
            {
                SetFocus(TextBoxFullName);
            }


            return false;
        }

        protected void BtnSignup_Click(object sender, EventArgs e)
        {
            string fullName = TextBoxFullName.Text;
            string userName = TextBoxUserName.Text;
            string passRepeat = TextBoxPassWordRepeat.Text;
            string passWord = TextBoxPassWord.Text;

            if (isValid(fullName, userName, passWord, passRepeat))
            {

                if (UserHelpers.CheckUserNameExist(userName))
                {
                    Helpers.RenderAlerts(Helpers.AlertType.warning, LabelWarning, $"Tên đăng nhập đã được sử dụng!");
                    SetFocus(TextBoxUserName);
                }
                else
                {
                    string passWordEncode = Helpers.EncodePassWord(passWord);
                    UserHelpers.Add(fullName, userName, passWord);
                }

                Helpers.RenderAlerts(Helpers.AlertType.success, LabelWarning, $"Đăng ký thành công!");
            }
        }
    }
}