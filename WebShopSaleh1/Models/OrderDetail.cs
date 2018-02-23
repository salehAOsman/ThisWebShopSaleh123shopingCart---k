using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShopSaleh1.Models
{
////*8/2
//    public class OrderDetail
//    {
//        public int RecordId { get; set; }
//        public string CartId { get; set; }
//        public int Quantity { get; set; }
//        public DateTime DateCreated { get; set; }

//        public Product Products { get; set; }            // reference for people
//    }
//    //*8/2

    //*8/2
    public class OrderDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }


        public Product Products { get; set; }            // reference for people
    }
    //*8/2
}