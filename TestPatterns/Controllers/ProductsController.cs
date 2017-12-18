using Patterns.Singleton;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TestPatterns.Contracts;
using TestPatterns.Factory;
using TestPatterns.Models;
using TestPatterns.ViewModels;

namespace TestPatterns.Controllers
{
    public class ProductsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

		// GET: Products
		public ActionResult Index()
        {
            return View(db.Products.ToList());
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
			var categories = db.Categories.ToList();
			var viewModel = new ProductViewModel
			{
				Categories = categories
			};

            return View(viewModel);
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
				//Force a exception to create a log using singleton instance
				//throw new Exception("Test log singleton");

				//Cople code without factory pattern
				//if (product.CategoryId == 1)
				//{
				//	product.Bonus = 5;
				//	product.Tax = 2;
				//}
				//else if (product.CategoryId == 2)
				//{
				//	product.Bonus = 2;
				//	product.Tax = 5;
				//}
				//else if (product.CategoryId == 3)
				//{
				//	product.Bonus = 1;
				//	product.Tax = 7;
				//}

				//Simple factory
				ProductManagerFactory prodFactory = new ProductManagerFactory();
				IProductManager prodManager = prodFactory.GetProductManager(product.CategoryId);
				product.Bonus = prodManager.GetBonus();
				product.Tax = prodManager.GetTax();

				db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

			var viewModel = new ProductViewModel
			{
				Categories = db.Categories.ToList()
			};
			return View(viewModel);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Description")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
