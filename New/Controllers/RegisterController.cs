using System.Linq;
using System.Web.Mvc;
using New.Models;

namespace New.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        POSDBEntities db = new POSDBEntities();
        public ActionResult SaveData(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            return Json(new { success = true, message = "Saved Successfully!" }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult NewAdmin(Admin admin)
        {
            db.Admins.Add(admin);
            db.SaveChanges();
            return Json(new { success = true, message = "Admin is Added successfully" }, JsonRequestBehavior.AllowGet);
        }
    }
}