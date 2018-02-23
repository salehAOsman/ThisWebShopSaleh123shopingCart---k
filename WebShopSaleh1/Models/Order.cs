using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShopSaleh1.Models
{
//*8/1   
    public class Order
    {
        public int Id { get; set; }
        public string DateTime { get; set; }
        
        //We use the "ApplicationUser" instead of "User" class Because it has default name as Identity
        public ApplicationUser People { get; set; }                           //reference to people
        public ICollection<OrderDetail> OrderDetails { get; set; } //add column as list for mor details

        //*8/1

        //private List<OrderDetail> detailCollection = new List<OrderDetail>();

        //public void AddItem(Product product, int quantity)
        //{
        //    OrderDetail detail = detailCollection
        //        .Where(p => p.Products.Id == product.Id).FirstOrDefault();

        //    if (detail==null)
        //    {
        //        detailCollection.Add(new OrderDetail { Products = product, Quantity = quantity });
        //    }
        //    else
        //    {
        //        detail.Quantity += quantity;
        //    }
        //}

        //public void RemoveDetail(Product product)
        //{
        //    detailCollection.RemoveAll(d => d.Products.Id == product.Id);
        //}

        //public float ComputeTotalValue()
        //{
        //    return detailCollection.Sum(e => e.Products.Price * e.Quantity);
        //}

        //public void Clear()
        //{
        //    detailCollection.Clear();
        //}

        //public ICollection<OrderDetail> details {
        //    get { return detailCollection; }
        //}
    }
   }