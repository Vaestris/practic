using System;

namespace internet_shop_test2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db=new ProgramContext())
            {
                db.products.Add(new product { product_number = 1, existence = 1, name = "штука" });
                db.SaveChanges();
            }
        }
    }
}
