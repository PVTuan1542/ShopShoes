using Login.Models.DAO;
using Login.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        private DBConnect db = new DBConnect();
        // GET: Admin/Account
        public ActionResult Index()
        {
            var dao = new shopDAO();
            var model = dao.listAccount();
            return View(model);
        }

        public ActionResult SearchByNameAccount(String name)
        {
            @ViewBag.key = name;
            List<Account> aList = db.Accounts.Where(x => x.user.Contains(name)).ToList();
            return View(aList);
        }
        // GET: Admin/Product/Delete/5
        public ActionResult Delete(int id)
        {
            using (DBConnect db = new DBConnect())
            {
                Account ac = db.Accounts.Where(x => x.uID == id).FirstOrDefault();

                db.Accounts.Remove(ac);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
    
}