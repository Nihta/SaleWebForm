using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace SaleWebForm
{
    class CategoryHelpers
    {
        public static void GridViewHelper(GridView gridView)
        {
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                var query = from item in db.tblCategories
                            orderby item.categoryId descending
                            select new
                            {
                                CategoryID = item.categoryId,
                                CategoryName = item.name,
                                Description = item.description
                            };

                gridView.DataSource = query.ToList();
                gridView.DataBind();
            }
        }

        public static List<tblCategory> GetList()
        {
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                var query = from item in db.tblCategories
                            orderby item.categoryId descending
                            select item;

                return query.ToList();
            }
        }

        public static void Add(string categoryName, string description)
        {
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                var itemNewAdd = new tblCategory();

                itemNewAdd.name = categoryName;
                itemNewAdd.description = description;

                db.tblCategories.InsertOnSubmit(itemNewAdd);
                db.SubmitChanges();
            }
        }
    }
}