using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaleWebForm
{
    public class BrandHelpers
    {
        public static List<tblBrand> GetList()
        {
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                var query = from item in db.tblBrands
                            orderby item.brandId descending
                            select item;

                return query.ToList();
            }
        }

        public static void Add(string categoryName, string description)
        {
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                var itemNewAdd = new tblBrand();

                itemNewAdd.name = categoryName;
                itemNewAdd.description = description;

                db.tblBrands.InsertOnSubmit(itemNewAdd);
                db.SubmitChanges();
            }
        }

        public static void Edit(int categoryID, string categoryName, string description)
        {
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                var itemNeedEdit = db.tblBrands.First(item => item.brandId == categoryID);

                itemNeedEdit.name = categoryName;
                itemNeedEdit.description = description;

                db.SubmitChanges();
            }
        }

        public static void Delete(int categoryID)
        {
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                var itemNeedDel = db.tblBrands.First(item => item.brandId == categoryID);

                db.tblBrands.DeleteOnSubmit(itemNeedDel);
                db.SubmitChanges();
            }
        }
    }
}