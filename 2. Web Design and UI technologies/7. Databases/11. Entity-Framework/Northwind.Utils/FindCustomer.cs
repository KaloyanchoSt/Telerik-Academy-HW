using Northwind.Data;
using System;
using System.Linq;

namespace Northwind.Utils
{
    public class FindCustomer
    {
        // Task 3
        public static void FindAllCustomers(int orderDate, string shipDestination)
        {
            NorthwindEntities db = new NorthwindEntities();
            using (db)
            {
                var customers =
                    from order in db.Orders
                    where order.OrderDate.Value.Year == orderDate && order.ShipCountry == shipDestination
                    select order;

                foreach (var customer in customers)
                {
                    Console.WriteLine("Customer: {0}", customer.Customer.ContactName);
                }
            }
        }

        // Task 4
        private static void FindAllCustomersSql(int orderDate, string shipDestination)
        {
            NorthwindEntities db = new NorthwindEntities();
            using (db)
            {
                string customersQuery = @"SELECT c.ContactName from Customers
                                    c INNER JOIN Orders o ON o.CustomerID = c.CustomerID 
                                    WHERE (YEAR(o.OrderDate) = {0} AND o.ShipCountry = {1});";
                object[] queryParams = { orderDate, shipDestination };

                var customersResult = db.Database.SqlQuery<string>(customersQuery, queryParams);

                foreach (var customer in customersResult)
                {
                    Console.WriteLine("Customer: {0}", customer);
                }
            }
        }
    }
}
