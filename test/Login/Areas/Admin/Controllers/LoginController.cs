using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Login.Areas.Admin.Data;
using Model.DAO;

namespace Login.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel user)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDAO();
                var result = dao.login(user.UserName , user.PassWord);
                if(result ==1 )
                {
                    ModelState.AddModelError("", "Login succeed");
                }else
                {
                    ModelState.AddModelError("", "Login not succeed");
                }

            }
            return View("Index");
        }
    }
}