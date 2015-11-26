using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AlkorbiUniversity.Models;

namespace AlkorbiUniversity.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            using (AccountDbContext db = new AccountDbContext())
            {
                return View(db.userAccount.ToList());
            }
        }
        //Method to create a new user account and save it in the Db
        public ActionResult Register()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Register(UserAccount account)
        {
            if (ModelState.IsValid)
            {
                using (AccountDbContext db = new AccountDbContext())
                {
                    db.userAccount.Add(account);
                    db.SaveChanges();
                }

                ModelState.Clear();
                ViewBag.Message = account.FristName + " " + account.LastName + "  Congratulations, you are sucessfully registered.";

            }
            return View();
        }
        //Get Method for login
        public ActionResult Login()
        {
            return View();
        }
        //Post method for login
        [HttpPost]

        public ActionResult Login(UserAccount user)
        {
            using (AccountDbContext db = new AccountDbContext())
            {
                var usr = db.userAccount.Single(u => u.Username == user.Username && u.Password == user.Password);
                if (usr != null)
                {
                    Session["UserID"] = user.UserID.ToString();
                    Session["Username"] = user.Username.ToString();
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("","The username or password you have entered is incorrect, please try again.");

                }
            }

            return View();
        }
        //method for the login page
        public ActionResult LoggedIn()
        {
            if (Session ["UserId"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
    }
