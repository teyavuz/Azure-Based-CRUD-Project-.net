using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;


namespace BulutBilişim.Controllers
{
    public class SecurityController : Controller
    {

        bulutbilisimEntities db = new bulutbilisimEntities();
        // GET: Security
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Admin admin)
        {
            var bilgiler = db.Admins.FirstOrDefault(x => x.AdminName == admin.AdminName && admin.AdminPassword == admin.AdminPassword);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.AdminName, false);
                Session["AdminName"] = bilgiler.AdminName;
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }

    }
}