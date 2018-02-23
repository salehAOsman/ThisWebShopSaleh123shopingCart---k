using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebShopSaleh1.Models;
using System.Linq.Dynamic;

namespace WebShopSaleh1.Controllers
{
    public class PeopleController : Controller
    {

        //Get 
        //This method for adding jQuery
        public ActionResult Index()
        {
            return View();
        }

        //Write for return database data
        public ActionResult loaddata()
        {
            WebSalehEntities dc = new WebSalehEntities();

            var data = dc.AspNetUsers.OrderBy(a => a.FullName).ToList();
            List<UserViewModel> temp = new List<UserViewModel>();
            
            foreach (var item in data)
            {
                temp.Add(new UserViewModel() { Id=item.Id, Address = item.Address, City = item.City, Email = item.Email, FullName = item.FullName });
               
            }
            return Json(new { data = temp }, JsonRequestBehavior.AllowGet);
        }
        
        ////Write for return database data
        //public ActionResult loaddata()
        //{
        //This name exp"DefaultConnectionEntities" create after we create ADO.NET data model over already Database that means, it is not EF empty
        //    DefaultConnectionEntities dc = new DefaultConnectionEntities();

        //    var data = dc.AspNetUsers.OrderBy(a => a.FullName).ToList();
        //    List<UserViewModel> temp = new List<UserViewModel>();

        //    foreach (var item in data)
        //    {
        //        temp.Add(new UserViewModel() { Id = item.Id, Address = item.Address, City = item.City, Email = item.Email, FullName = item.FullName });
        //    }
        //    return Json(new { data = temp }, JsonRequestBehavior.AllowGet);
        //}


        ////Write for return data and filtering , sorting ..
        // GET: People
        //  public ActionResult Index()
        //  {

        //      return View();
        //  }

        //  //Write action for return json data
        //  [HttpPost]
        //  public ActionResult LoadData()
        //  {
        //      //1*Get parameters


        //     //2*Get start (paging start index) and length (page size for paging)
        //      var draw = Request.Form.GetValues("draw").FirstOrDefault();
        //      var start = Request.Form.GetValues("start").FirstOrDefault();
        //      var length = Request.Form.GetValues("length").FirstOrDefault();

        //      //3*Get sort columns value
        //      var sortColumn = Request.Form.GetValues("columns["+Request.Form.GetValues("order[0][column]").FirstOrDefault()+"][name]").FirstOrDefault();
        //      var sortColumnDir = Request.Form.GetValues("order[0][dir]").FirstOrDefault();

        //      int pageSize = length != null ? Convert.ToInt32(length) : 0;
        //      var skip = start != null ? Convert.ToInt32(start) : 0;
        //      int totalRecords = 0;

        //      using (DefaultConnectionEntities dc = new DefaultConnectionEntities())
        //      {
        //          var v = (from a in dc.AspNetUsers select a);
        //          //Sorting
        //          if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDir)))
        //          {
        //              v = v.OrderBy(sortColumn + "" + sortColumnDir);
        //          }
        //          totalRecords = v.Count();
        //          var data = v.Skip(skip).Take(pageSize).ToList();
        //          return Json(new { draw = draw, recordsFiltered = totalRecords, recordsToltal = totalRecords, data = data },JsonRequestBehavior.AllowGet);
        //      }
        //  }   
    }
}
