
using Login.Models.DAO;
using Login.Models.EF;
using Model.DAO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
       private DBConnect db = new DBConnect();
        // GET: Admin/Product
        public ActionResult Index()
        {
            var dao = new shopDAO();
            var model = dao.listProduct();
            return View(model);
        }
        // GET: Admin/Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        // GET: Admin/Product/Create
        public ActionResult Create()
        {
                return View();
        }

        // POST: Admin/Product/Create
        [HttpPost]
        public ActionResult Create(product p)
        {
            try
            {
                // TODO: Add insert logic here
                shopDAO.AddProduct(p);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Product/Edit/5
        public ActionResult Edit(int id)
        {
            using (DBConnect db = new DBConnect())
            {
                product pro = db.products.Where(x => x.id == id).FirstOrDefault();
                return View(pro);
            }
               
        }

        // POST: Admin/Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, product product)
        {
            try
            {
                // TODO: Add update logic here
                using (DBConnect db = new DBConnect())
                {
                    db.Entry(product).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Product/Delete/5
        public ActionResult Delete(int id)
        {
            using (DBConnect db = new DBConnect())
            {
                product product = db.products.Where(x => x.id == id).FirstOrDefault();
                db.products.Remove(product);
                db.SaveChanges();
            }
            return RedirectToAction("Index"); 
        }

        // POST: Admin/Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
              
                    return RedirectToAction("Index");
                
            }
            catch
            {
                return View();
            }
        }

        public ActionResult SearchByName(String name)
        {
            @ViewBag.key = name;
            List<product> pList = db.products.Where(x => x.name.Contains(name)).ToList();
            return View(pList);
        }
    }
}
