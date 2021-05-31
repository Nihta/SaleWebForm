using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SaleWebForm
{
    public class UserHelpers
    {
        public static List<tblUser> GetList()
        {
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                var query = from item in db.tblUsers
                            orderby item.userId descending
                            select item;

                return query.ToList();
            }
        }

        public static void Add(string fullName, string userName, string email, string passWord, int role = 0)
        {
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                tblUser itemNewAdd = new tblUser();

                string passWordEndcode = Helpers.EncodePassWord(passWord);
                itemNewAdd.fullName = fullName;
                itemNewAdd.userName = userName;
                itemNewAdd.email = email;
                itemNewAdd.passWord = passWordEndcode;
                itemNewAdd.role = role;

                db.tblUsers.InsertOnSubmit(itemNewAdd);
                db.SubmitChanges();
            }
        }

        public static void Edit(int userID, string fullName, string userName, string email, string passWord, int role = 0)
        {
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                var itemNeedEdit = db.tblUsers.First(user => user.userId == userID);

                string passWordEndcode = Helpers.EncodePassWord(passWord);
                itemNeedEdit.fullName = fullName;
                itemNeedEdit.userName = userName;
                itemNeedEdit.email = email;
                itemNeedEdit.passWord = passWordEndcode;
                itemNeedEdit.role = role;

                db.SubmitChanges();
            }
        }


        /// <summary>
        /// Đăng nhập
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="passWord"></param>
        /// <returns>
        /// Đăng nhập thành công trả về mã người dùng, ngược lại trả về -1
        /// </returns>
        public static int Login(string userName, string passWord)
        {
            string passWordEndcode = Helpers.EncodePassWord(passWord);

            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                IQueryable<tblUser> query = from item in db.tblUsers
                                            where (item.userName == userName) && (item.passWord == passWordEndcode)
                                            select item;

                if (query.Count() != 0)
                {
                    return query.First().userId;
                }
            }

            return -1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="ignoreUserId"></param>
        /// <returns>
        /// Return true nếu đã được sử dụng
        /// </returns>
        public static bool CheckUserNameExist(string userName, int ignoreUserId = -1)
        {
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                int cnt = db.tblUsers.Count(user => user.userName == userName && user.userId != ignoreUserId);
                return cnt > 0;
            }
        }

        public static tblUser GetUserById(int userID)
        {
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                tblUser query = db.tblUsers.First(user => user.userId == userID);

                return query;
            }
        }

        public static void Add(string fullName, string userName, string passWord)
        {
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                tblUser itemNewAdd = new tblUser();

                string passWordEndcode = Helpers.EncodePassWord(passWord);
                itemNewAdd.fullName = fullName;
                itemNewAdd.userName = userName;
                itemNewAdd.passWord = passWordEndcode;

                db.tblUsers.InsertOnSubmit(itemNewAdd);
                db.SubmitChanges();
            }
        }

        public static bool UpdateUser(int userID, string fullName, string passWord)
        {
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                try
                {
                    tblUser objUser = db.tblUsers.Single(user => user.userId == userID);

                    string passWordEndcode = Helpers.EncodePassWord(passWord);

                    objUser.fullName = fullName;
                    objUser.passWord = passWordEndcode;

                    db.SubmitChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    // Debug
                    Debug.WriteLine(ex.Message);
                    return false;
                }
            }
        }

        public static void Edit(int userID, string fullName, string userName, string passWord)
        {
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                var itemNeedEdit = db.tblUsers.First(user => user.userId == userID);

                string passWordEndcode = Helpers.EncodePassWord(passWord);
                itemNeedEdit.fullName = fullName;
                itemNeedEdit.userName = userName;
                itemNeedEdit.passWord = passWordEndcode;

                db.SubmitChanges();
            }
        }

        public static void Delete(int userID)
        {
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                var itemNeedDel = db.tblUsers.First(user => user.userId == userID);

                db.tblUsers.DeleteOnSubmit(itemNeedDel);
                db.SubmitChanges();
            }
        }
    }
}