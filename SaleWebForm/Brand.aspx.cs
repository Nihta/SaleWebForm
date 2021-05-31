using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SaleWebForm
{
    public partial class WebForm3 : System.Web.UI.Page
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
            string tblId = "tbl-brand";
            string thead = TableHelpers.MakeThead("ID", "Brand", "Description");

            string tbody = "";
            List<tblBrand> data = BrandHelpers.GetList();

            maxPage = (int)Math.Ceiling(data.Count / (numItemPerPage * 1.0));

            for (int i = (pageCur - 1) * numItemPerPage; i < data.Count && i < pageCur * numItemPerPage; i++)
            {
                tblBrand brand = data[i];
                tbody += TableHelpers.MakeRow(
                    brand.brandId.ToString(),
                    brand.name,
                    brand.description
                );
            }

            string html = TableHelpers.MakeTable(thead, tbody, tblId);
            LiteralTable.Text = html;

            LiteralPagination.Text = TableHelpers.MakePagination(1, maxPage, pageCur);
            LiteralPaginationInfo.Text = $"<div class='dataTable-info'>Show {(pageCur - 1) * numItemPerPage + 1} to {Math.Min(data.Count, pageCur * numItemPerPage)} of {data.Count} item</div>";
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
                BrandHelpers.Add(name, desc);

                RenderTable();
                Helpers.ClearInput(TextBoxAddName, TextBoxAddDesc);
            }

            if (mode.Text == "EDIT")
            {
                int id = Convert.ToInt32(IdCateCur.Text);
                BrandHelpers.Edit(id, name, desc);

                RenderTable();
                Helpers.ClearInput(TextBoxAddName, TextBoxAddDesc);
            }
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdCateCur.Text);
            BrandHelpers.Delete(id);

            RenderTable();
        }
    }
}