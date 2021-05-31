using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SaleWebForm
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        private int pageCur = 1;
        private int maxPage = 1;

        protected void Page_Load(object sender, EventArgs e)
        {
            RenderTable();
        }

        private void RenderTable()
        {
            int numItemPerPage = Convert.ToInt32(DropDownListNumOfItemInPage.SelectedValue.ToString());

            string tblId = "tbl-category";
            string thead = TableHelpers.MakeThead("ID", "User Name", "Full Name", "Email");

            string tbody = "";
            List<tblUser> data = UserHelpers.GetList();

            maxPage = (int)Math.Ceiling(data.Count / (numItemPerPage * 1.0));

            for (int i = (pageCur - 1) * numItemPerPage; i < data.Count && i < pageCur * numItemPerPage; i++)
            {
                tblUser user = data[i];
                tbody += TableHelpers.MakeRow(
                    user.userId.ToString(),
                    user.userName,
                    user.fullName,
                    user.email
                );
            }

            string html = TableHelpers.MakeTable(thead, tbody, tblId);
            LiteralTable.Text = html;

            LiteralPagination.Text = TableHelpers.MakePagination(1, maxPage, pageCur);
            LiteralPaginationInfo.Text = $"<div class='dataTable-info'>Show {(pageCur - 1) * numItemPerPage + 1} to {Math.Min(data.Count, pageCur * numItemPerPage)} of {data.Count} users</div>";
        }


        protected void gridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.TableSection = TableRowSection.TableHeader;
            }
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {

            string fullName = TextBoxFullName.Text;
            string userName = TextBoxUserName.Text;
            string email = TextBoxEmail.Text;
            string passWord = TextBoxPassWord.Text;


            if (mode.Text == "ADD")
            {
                UserHelpers.Add(fullName, userName, email, passWord, 0);

                RenderTable();
                Helpers.ClearInput(TextBoxFullName, TextBoxUserName, TextBoxEmail, TextBoxPassWord);
            }

            if (mode.Text == "EDIT")
            {
                int id = Convert.ToInt32(IdCateCur.Text);
                UserHelpers.Edit(id, fullName, userName, email, passWord, 0);

                RenderTable();
                Helpers.ClearInput(TextBoxFullName, TextBoxUserName, TextBoxEmail, TextBoxPassWord);

            }
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdCateCur.Text);
            UserHelpers.Delete(id);

            RenderTable();
        }

        protected void DropDownListNumOfItemInPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            RenderTable();
        }
    }
}