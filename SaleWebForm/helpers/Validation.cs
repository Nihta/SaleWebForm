using System.Text.RegularExpressions;
using System.Web.UI.WebControls;

namespace SaleWebForm
{
    public class Validation
    {
        public static bool IsNumeric(Label label, string text, string name)
        {
            if (!Regex.IsMatch(text, @"^\d+$"))
            {
                Helpers.RenderAlerts(Helpers.AlertType.warning, label, $"{name} không phải là số hợp lệ!");
                return false;
            }

            return true;
        }


        public static bool IsTextInvalid(Label label, string text, int min, int max, string name, bool isRequire = true)
        {
            if (!isRequire && text.Length == 0)
            {
                return true;
            }

            if (text.Length == 0)
            {
                Helpers.RenderAlerts(Helpers.AlertType.warning, label, $"{name} là bắt buộc !");
                return false;
            }

            if (text.Length < min)
            {
                Helpers.RenderAlerts(Helpers.AlertType.warning, label, $"{name} quá ngắn!");
                return false;
            }

            if (text.Length > max)
            {
                Helpers.RenderAlerts(Helpers.AlertType.warning, label, $"{name} quá dài!");
                return false;
            }

            return true;
        }


        public static bool IsPhoneInvalid(Label label, string text)
        {
            if (!Regex.IsMatch(text, @"^[0-9]*$"))
            {
                Helpers.RenderAlerts(Helpers.AlertType.warning, label, $"Số điện thoại không hợp lệ!\nSố điện thoại chỉ bao gồm các số 0->9");
                return false;
            }

            return true;
        }


        public static bool IsEmailInvalid(Label label, string text)
        {
            if (!Regex.IsMatch(text, @"^\b[\w\.-]+@[\w\.-]+\.\w{2,4}\b$"))
            {
                Helpers.RenderAlerts(Helpers.AlertType.warning, label, $"Email không hợp lệ!");
                return false;
            }

            return true;
        }
    }

}