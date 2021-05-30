using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SaleWebForm
{
    public partial class FrmCategory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            //gridView.HeaderRow.TableSection = TableRowSection.TableHeader;

            GetDataGridView();

            RenderTable();
        }

        private void GetDataGridView()
        {
        }

        private void RenderTable()
        {
            string tblId = "tbl-category";
            string thead = TableHelpers.MakeThead("ID", "Danh mục", "Mô tả");

            string tbody = "";
            List<tblCategory> data = CategoryHelpers.GetList();
            data.ForEach(cate => tbody += TableHelpers.MakeRow(
                cate.categoryId.ToString(),
                cate.name,
                cate.description)
            );

            string html = TableHelpers.MakeTable(thead, tbody, tblId);
            LiteralTable.Text = html;

            LiteralPagination.Text = TableHelpers.MakePagination(1, 5, 1);
        }


        protected void gridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.TableSection = TableRowSection.TableHeader;
            }
        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {

        }
    }
}