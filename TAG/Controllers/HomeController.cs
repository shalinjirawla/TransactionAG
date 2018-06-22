using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TAG.Models;

namespace TAG.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationUserManager _userManager;
        public HomeController(ApplicationUserManager userManager)
        {
            UserManager = userManager;
        }
        public HomeController()
        {
        }
        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
        public ActionResult ContactInfo()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
        [HttpPost]
        public ActionResult SaveContactInfo(ContactModel data)
        {
            try
            {
                var user = UserManager.FindById(User.Identity.GetUserId());
                var getQuery = "select ContactId from Contact where ContactId='" + User.Identity.GetUserId() + "'";
                var contact = ClassDB.CheckRecord(getQuery);
                if (contact == null || contact == "")
                {
                    var query = "insert into Contact (ContactId,FirstName,LastName,JobTitle,Department,MobilePhone,EMailAddress1) values('" + User.Identity.GetUserId() + "','" +
                   data.FirstName + "','" + data.LastName + "','" +
                   data.JobTitle + "','" + data.Department + "','" +
                   data.MobilePhone + "','" + data.EMailAddress1 + "') SELECT SCOPE_IDENTITY()";
                    var result = ClassDB.Insert(query);
                }
                else
                {
                    var query = @"update Contact set FirstName = '"+ data.FirstName + @"',
                                    LastName = '" + data.LastName + @"',
                                    JobTitle = '"+ data.JobTitle + @"',
                                    Department = '"+ data.Department + @"',
                                    MobilePhone = '"+ data.MobilePhone + @"',
                                    EMailAddress1 = '"+ data.EMailAddress1 + "' where ContactId='" + User.Identity.GetUserId() + "'";
                    var result = ClassDB.update(query);
                }
                user.UserProfileCompleted = true;
                UserManager.Update(user);
                return RedirectToAction("AccountInfo", "Account");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}