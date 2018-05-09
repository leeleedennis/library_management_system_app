using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LMS_WebApplication;

namespace LMS_WebApplication.Controllers
{
    public class UsersController : Controller
    {
        private LibraryManagementEntities db = new LibraryManagementEntities();
        public string tempId;

        // GET: Users
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }

        // GET: Users/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,User_Name,Password,Type,Date_Created,Created_by")] User user)
        {
            if (ModelState.IsValid)
            {
                user.User_Name = TempData["StudId"] as string;
                user.Password = EasyEncryption.SHA.ComputeSHA256Hash(user.Password);
                user.Type = "Student";
                user.Date_Created = DateTime.Now;
                user.Created_by = "Online Portal";
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Login");
            }

            return View(user);
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,User_Name,Password,Type,Date_Created,Created_by")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
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

        //Users Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            user.Password = EasyEncryption.SHA.ComputeSHA256Hash(user.Password);
            var usr = db.Users.Any(q => q.User_Name == user.User_Name && q.Password == user.Password);
            if (usr)
            {
                Session["Username"] = user.User_Name.ToString();
                tempId = user.User_Name;
                return RedirectToAction("Welcome", "Books");
            }
            ModelState.AddModelError("", "Username or password Incorrect");
            return View();
        
        }

        // GET: Users/Edit/5
        public ActionResult ChangePassword()
        {
            /*if (tempId == )
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }*/
            string username = Session["Username"].ToString();
            User user = db.Users.FirstOrDefault(q=> q.User_Name == username);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangePassword([Bind(Include = "Id, User_Name, Password")] User user)
        {
            if (ModelState.IsValid)
            {
                var u = db.Users.FirstOrDefault(q => q.Id == user.Id);
                u.Password = EasyEncryption.SHA.ComputeSHA256Hash(user.Password);
                db.Entry(u).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Login");
            }
            return View(user);
        }

        public ActionResult Logout()
        {
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("Index","Home");
        }
    }
}
