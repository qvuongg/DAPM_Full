using DAPM_Full.Models.EF;
using System.Linq;
using System.Web.Mvc;

namespace DAPM_Full.Areas.RestaurantOwner.Controllers
{
    public class OrderController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Admin/Order
        public ActionResult Index()
        {
            var orders = db.DonHangs.Include("NguoiDung").Include("QuanAn").ToList();
            return View(orders);
        }

        // GET: Admin/Order/Approve/5
        public ActionResult Approve(int id)
        {
            var order = db.DonHangs.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }

            order.trangThaiHoatDong = true; // 'A' cho duyệt (Approved)
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: Admin/Order/Reject/5
        public ActionResult Reject(int id)
        {
            var order = db.DonHangs.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }

            order.trangThaiHoatDong = false;  // 'R' cho từ chối (Rejected)
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
