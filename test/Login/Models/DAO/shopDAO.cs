using Login.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login.Models.DAO
{
    public class shopDAO
    {
        private DBConnect db;

        public shopDAO()
        {
            db = new DBConnect();
        }
        public List<product> listProduct()
        {
            return db.products.ToList();
        }
        public static void AddProduct(product product)
        {
            DBConnect db = new DBConnect();
            db.products.Add(product);
            db.SaveChanges();
        }
        public List<Account> listAccount()
        {
            return db.Accounts.ToList();
        }

    }
}