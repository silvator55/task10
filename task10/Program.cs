using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Extensions.Options;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using task10.Data;

namespace task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext _contest = new ApplicationDbContext();
            //var customers = _contest.Customers.AsQueryable();
            //1-List all customers' first and last names along with their email addresses.
            //foreach (var customer  in customers)
            //{
            //    Console.WriteLine($"{customer.FirstName}, {customer.LastName}, {customer.Email}");

            //}


            //Retrieve all orders processed by a specific staff member (e.g., staff_id = 3).
            //var orders = _contest.Orders.AsQueryable().Where(o => o.StaffId == 3);
            //foreach(var order in orders)
            //{
            //    Console.WriteLine($"{order.OrderId},{order.OrderDate}, {order.OrderStatus}");
            //}



            //3- Get all products that belong to a category named "Mountain Bikes".
            //var products = _contest.Products.AsQueryable().Where(p => p.Category.CategoryName == "Mountain Bikes");
            //foreach (var product in products)

            //{
            //    Console.WriteLine($"{product.ProductId},{product.ProductName},{product.ModelYear}, {product.ListPrice}");
            //}

            //4-Count the total number of orders per store.

            //var storeorder = _contest.Orders.AsQueryable().GroupBy(o => o.Store.StoreName).Select(g => new { StoreName = g.Key, Totalorders = g.Count() });
            //foreach(var item in storeorder)
            //{
            //    Console.WriteLine($"{item.StoreName},{item.Totalorders}");
            //}



            //5- List all orders that have not been shipped yet (shipped_date is null).
            //var orders = _contest.Orders.AsQueryable().Where(o => o.ShippedDate == null);
            //foreach (var order in orders)
            //{
            //    Console.WriteLine($"{order.OrderId},{order.OrderDate},{order.OrderStatus}");
            //}


            // 6Display each customer’s full name and the number of orders they have placed.

            //var custoorder = _contest.Customers.AsQueryable().Select(c => new { fulname = c.FirstName + " " + c.LastName, totalorder = c.Orders.Count() });
            //foreach(var item in custoorder)
            //{
            //    Console.WriteLine($"{item.fulname}, {item.totalorder}");
            //}


            //7 List all products that have never been ordered (not found in order_items).
            //var products = _contest.Products.AsQueryable().Where(p => !p.OrderItems.Any());
            //foreach(var product in products)
            //{
            //    Console.WriteLine($"{product.ProductId},{product.ProductName},{product.ListPrice}");
            //}


            //8Display products that have a quantity of less than 5 in any store stock.
            //var products = _contest.Products.AsQueryable().Where(p => p.Stocks.Any(s => s.Quantity < 5));
            //foreach(var product in products)
            //{
            //    Console.WriteLine($"{product.ProductId}, {product.ProductName},{product.ListPrice}");

            //}

            //9 Retrieve the first product from the products table.


            //var product = _contest.Products.AsQueryable().FirstOrDefault();
            //if(product != null)
            //{
            //    Console.WriteLine($"{product.ProductId},{product.ProductName},{product.ListPrice}");
            //}

            //10- Retrieve all products from the products table with a certain model year.
            //int year = 2016;
            //var products = _contest.Products.AsQueryable().Where(p => p.ModelYear == year);

            //foreach(var product in products)
            //{
            //    Console.WriteLine($"{product.ModelYear}");
            //}


            //11- Display each product with the number of times it was ordered.

            //var resylt = _contest.Products.AsQueryable().Select(p => new { p.ProductId, p.ProductName, ordercount = p.OrderItems.Count() });

            //foreach(var item in resylt)
            //{
            //    Console.WriteLine($"{item.ProductName},{item.ProductId},{item.ordercount}");
            //}

            //12- Count the number of products in a specific category.
            //int targetcid = 1;
            //var result = _contest.Products.AsQueryable().Where(p => p.CategoryId == targetcid).GroupBy(p => p.CategoryId).Select(g => new { categoryid = g.Key, ProductCount = g.Count() });
            // foreach(var item in result)
            //{
            //    Console.WriteLine($"{item.categoryid}, {item.ProductCount}");
            //}


            //13- Calculate the average list price of products.
            //var result = _contest.Products.AsQueryable().GroupBy(p => 1).Select(g => new { Averageprice = g.Average(p => p.ListPrice) });
            //foreach(var item in result)
            //{
            //    Console.WriteLine($"{item.Averageprice}");
            //}


            // 14- Retrieve a specific product from the products table by ID.

            //int tpid = 20;
            //var products = _contest.Products.AsQueryable().Where(p => p.ProductId == tpid);
            //foreach(var product in products)
            //{
            //    Console.WriteLine(product);
            //}


            // 15- List all products that were ordered with a quantity greater than 3 in any order.

            //int tq = 5;
            //var products = _contest.Products.AsQueryable().Where(p => p.OrderItems.Any(amr => amr.Quantity > tq));

            //foreach(var product in products)
            //{
            //    Console.WriteLine(product);
            //}




            // 16- Display each staff member’s name and how many orders they processed.


            //var staforder = _contest.Staffs.AsQueryable().Select(s => new { satffname = s.FirstName + " " + s.LastName, ordercount = s.Orders.Count() });

            //foreach(var item in staforder)
            //{
            //    Console.WriteLine($"{item.satffname}, {item.ordercount}");
            //}


            // 1717- List active staff members only (active = true) along with their phone numbers.

            //byte actstate = 1;
            //var actstaffs  = _contest.Staffs.AsQueryable().Where(m => m.Active == actstate).Select(m => new { staffname = m.FirstName + " " + m.LastName, m.Phone });

            //foreach (var staff in actstaffs)
            //{
            //    Console.WriteLine($"{staff.staffname},{staff.Phone}");
            //}

            // 18 18- List all products with their brand name and category name.
            //var products = _contest.Products.AsQueryable().Select(amr => new { amr.ProductName, BrandName = amr.Brand.BrandName, catname = amr.Category.CategoryName });
            //foreach(var item in products)
            //{
            //    Console.WriteLine($"{item.ProductName},{item.BrandName}, {item.catname}");
            //}

            //19 19- Retrieve orders that are completed.


            //byte compstatues = 5;
            //var compleorders = _contest.Orders.AsQueryable().Where(o => o.OrderStatus == compstatues);

            //foreach(var order in compleorders)
            //{
            //    Console.WriteLine(order);
            //}

            //20 

            //var prodsold = _contest.Products.AsQueryable().Select(p => new { p.ProductName, TQS = p.OrderItems.Sum(amr => (int?)amr.Quantity) ?? 0 });
            //foreach(var item in prodsold)
            //{
            //    Console.WriteLine($"{item.ProductName}, {item.TQS}");
            //}


        }
    }
}
