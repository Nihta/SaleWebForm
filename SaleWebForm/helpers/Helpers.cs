using System.Security.Cryptography;
using System.Text;
using System.Web.UI.WebControls;

namespace SaleWebForm
{
    public class Helpers
    {
        public enum AlertType
        {
            primary,
            danger,
            warning,
            success,
            info,
        }

        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));
            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

        public static string EncodePassWord(string passWord)
        {
            return MD5Hash(MD5Hash(MD5Hash(passWord)));
        }

        public static void RenderAlerts(AlertType alertType, Label label, string message)
        {
            string alert = "";

            switch (alertType)
            {
                case AlertType.primary:
                    alert = "primary";
                    break;
                case AlertType.danger:
                    alert = "danger";
                    break;
                case AlertType.warning:
                    alert = "warning";
                    break;
                case AlertType.success:
                    alert = "success";
                    break;
                case AlertType.info:
                    alert = "info";
                    break;
                default:
                    alert = "primary";
                    break;
            }

            string html = $"<div class='alert alert-{alert}' role='alert'>{message}</div>";

            label.Text = html;
        }


        public static void ClearInput(params TextBox[] textBoxes)
        {
            foreach (TextBox tb in textBoxes)
            {
                tb.Text = "";
            }
        }
    }
}