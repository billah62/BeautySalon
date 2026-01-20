using System.Linq;
using System.Web.Mvc;
using BeautySalon.Models;
using Microsoft.AspNet.Identity;

namespace BeautySalon.Controllers
{
    [Authorize(Roles = "Admin")]
    public class DashboardController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var users = db.Users.ToList();
            var appointments = db.Appointments.ToList();
        var services = db.Services.ToList();

        var model = new AdminDashboardViewModel
        {
            Users = users,
            Appointments = appointments,
            Services = services
        };

        return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            if (id == User.Identity.GetUserId())
            {
                TempData["Error"] = "You cannot delete your own account!";
                return RedirectToAction("Index");
            }

            var user = db.Users.Find(id);
            if (user != null)
            {
                db.Users.Remove(user);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}