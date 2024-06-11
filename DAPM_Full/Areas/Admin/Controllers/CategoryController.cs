using DAPM_Full.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace DAPM_Full.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/Category
        public ActionResult Index()
        {
            var items = db.DanhMucs;
            return View(items);
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(DanhMuc model)
        {
            if (ModelState.IsValid)
            {
                
                db.DanhMucs.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public ActionResult Edit(int maDanhMuc)
        {
            var item = db.DanhMucs.Find(maDanhMuc);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // POST: Admin/Category/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DanhMuc model)
        {
            if (ModelState.IsValid)
            {
                db.DanhMucs.Attach(model);
                db.Entry(model).Property(x => x.tenDanhMuc).IsModified = true;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            // Ghi log toàn bộ trạng thái ModelState
            foreach (var key in ModelState.Keys)
            {
                var state = ModelState[key];
                foreach (var error in state.Errors)
                {
                    System.Diagnostics.Debug.WriteLine($"Key: {key}, Error: {error.ErrorMessage}");
                }
            }
            return View(model);
        }
        // POST: Admin/Category/Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int maDanhMuc)
        {
            var item = db.DanhMucs.Find(maDanhMuc);
            if (item == null)
            {
                return HttpNotFound();
            }

            db.DanhMucs.Remove(item);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}