using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebShopSaleh1.Models;

namespace WebShopSaleh1.Controllers
{
    //Teacher add controller Admin and three ActionResult

    [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateUser(FormCollection form)
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            string UserName = form["txtEmail"];  // we have to be carefully att Email = username
            string email = form["txtEmail"];     // we have to be carefully att Email = username
            string pwd = form["txtPassword"];

            //create default user                 
            var user = new ApplicationUser();
            user.UserName = UserName;
            user.Email = email;

            var newuser = userManager.Create(user,pwd);
            return View();
        }

        public ActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewRole(FormCollection form)
        {
            string rolename = form["RoleName"];
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            if (!roleManager.RoleExists(rolename))
            {
                //we create Admin role    
                var role = new IdentityRole(rolename);
                roleManager.Create(role);
            }
                return View("Index");
        }

        //GET AssignRole
        public ActionResult AssignRole()
        {
            ViewBag.Roles = context.Roles.Select(r => new SelectListItem { Value = r.Name, Text = r.Name }).ToList();

            return View();
        }

        [HttpPost]
        public ActionResult AssignRole(FormCollection form)
        {
            string usrname = form["txtUserName"];
            string rolname = form["RoleName"];

            //add new role for user to database when we assign role to another user
            ApplicationUser user = context.Users.Where(u => u.UserName.Equals(usrname, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            userManager.AddToRole(user.Id, rolname); 

            return View("Index");
        }
     }
}