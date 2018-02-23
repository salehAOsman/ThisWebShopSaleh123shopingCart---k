using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;

namespace WebShopSaleh1.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.

    public class ApplicationUser : IdentityUser

    {
//*10_  add here new properties for more informations for Users those will be inside "User" table 
       
        //Now we have an important step that called Customize profile Info for extend properties to new users when we will register new users
        //That will have four steps to do like this down
        //Before that we have to be shore is there IDENTITY and OWin Services to References
        //goto Models -> IdentityModels -> Models.cs -> Class ApplicationUser: line 12

        public string FullName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        //10*

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
          // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);

            //*Add down for identity claims and to know the "connectionTime" for user
            // Add custom user claims here
    //* 5 we can add own claims here exp Email and calculate how many times stay you in the current application as user
            //userIdentity.AddClaim(new Claim("user-email", this.Email));
            //userIdentity.AddClaim(new Claim("connectionTime", DateTime.Now.ToString()));
            //var dif = (DateTime.Now - DateTime.Now.AddHours(2)).TotalMinutes;
           //* 5
            // Add custom user claims here

            return userIdentity;
        }
    }

 //*9_     *It is DbContext class that we have to add DbSet here and we don't need to add "Role" 
         // and "User" here because it was built already inside Edentity as "ApplicationUser" 
         //but we don't have class as "Role"

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        //We write the name here, this name is the Database name in the SQL Server
        public ApplicationDbContext() : base("WebSaleh", throwIfV1Schema: false)
        {

        }

        static ApplicationDbContext()

        {
            Database.SetInitializer (new IdentityDbInit());
        }

        //we add here DbSet for classes that will make relation between each other 

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        
        //public System.Data.Entity.DbSet<Models.AppUser> AppUsers{get;set;}        

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }

        // public System.Data.Entity.DbSet<WebShopSaleh1.Models.ApplicationUser> ApplicationUsers { get; set; }
       
        //public System.Data.Entity.DbSet<WebShopSaleh1.Models.ApplicationUser> ApplicationUsers { get; set; } It dosn't need at adding this line, It will make fel in the program 
    }
    public class IdentityDbInit : DropCreateDatabaseIfModelChanges<IdentityDbContext>
    {
        protected override void Seed(IdentityDbContext context)
        { PerformInitialSetup(context); base.Seed(context); }

        public void PerformInitialSetup(IdentityDbContext context)
        {
            //initial configuration will go here 
        }
    }
    //*9_
}