using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BulutBilişim;

namespace BulutBilişim.Controllers
{
    public class UsersController : Controller
    {
        private bulutbilisimEntities db = new bulutbilisimEntities();

        
        // GET: Users/Create
        public ActionResult Create()
        {
            ViewBag.UserTypeID = new SelectList(db.UserTypes, "UserTypeID", "UserTypeName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserID,Name,Surname,Mission,PhoneNumber,MailAdress,Adress,Reference,UserTypeID")] User user)
        {
            if (ModelState.IsValid)
            {
                user.UserTypeID = 2;
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Create");
            }

            ViewBag.UserTypeID = new SelectList(db.UserTypes, "UserTypeID", "UserTypeName", user.UserTypeID);
            return View(user);
        }

    }
}
