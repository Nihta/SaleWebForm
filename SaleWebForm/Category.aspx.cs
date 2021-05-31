using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SaleWebForm
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private int numItemPerPage = 5;
        private int pageCur = 1;
        private int maxPage = 1;

        protected void Page_Load(object sender, EventArgs e)
        {
            RenderTable();
        }

        private void RenderTable()
        {
            string tblId = "tbl-category";
            string thead = TableHelpers.MakeThead("ID", "Danh mục", "Mô tả");

            string tbody = "";
            List<tblCategory> data = CategoryHelpers.GetList();

            maxPage = (int)Math.Ceiling(data.Count / (numItemPerPage * 1.0));

            for (int i = (pageCur - 1) * numItemPerPage; i < data.Count && i < pageCur * numItemPerPage; i++)
            {
                tblCategory cate = data[i];
                tbody += TableHelpers.MakeRow(
                    cate.categoryId.ToString(),
                    cate.name,
                    cate.description
                );
            }

            string html = TableHelpers.MakeTable(thead, tbody, tblId);
            LiteralTable.Text = html;

            LiteralPagination.Text = TableHelpers.MakePagination(1, maxPage, pageCur);
            LiteralPaginationInfo.Text = $"<div class='dataTable-info'>Hiển thị {(pageCur - 1) * numItemPerPage + 1} tới {Math.Min(data.Count, pageCur * numItemPerPage)} trên {data.Count} danh mục</div>";
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

            string name = TextBoxAddName.Text;
            string desc = TextBoxAddDesc.Text;


            if (mode.Text == "ADD")
            {
                CategoryHelpers.Add(name, desc);

                RenderTable();
                Helpers.ClearInput(TextBoxAddName, TextBoxAddDesc);
            }

            if (mode.Text == "EDIT")
            {
                int id = Convert.ToInt32(IdCateCur.Text);
                CategoryHelpers.Edit(id, name, desc);

                RenderTable();
                Helpers.ClearInput(TextBoxAddName, TextBoxAddDesc);
            }
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdCateCur.Text);
            CategoryHelpers.Delete(id);

            RenderTable();
        }
    }
}