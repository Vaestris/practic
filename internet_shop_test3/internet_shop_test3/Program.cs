using System;

namespace internet_shop_test2
{
    class Program
    {
        static void Main()
        {
            using (var db=new ProgramContext())
            {
               // db.Customers.Add(new customer {phone_number = 1, fname = "name", lname = "Lname", company = "company" });
               // db.Orders.Add(new order {phone_number = 1, id_order = 1, product_number = 1 });
                db.Products.Add(new product {product_number = 1, existence = 1, name = "shtuka" });
               // db.deliveries.Add(new delivery { order_number = 1, shipment = true, issued = true, delivered  = true, time = "";});
                db.SaveChanges();
            }
        }
    }
}
