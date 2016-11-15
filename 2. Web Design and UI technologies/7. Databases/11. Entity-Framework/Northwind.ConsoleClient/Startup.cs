using Northwind.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.ConsoleClient
{
    public class Startup
    {
        public static void Main()
        {
            var dbContext = new NorthwindEntities();
            var categories = dbContext.Categories;
            foreach (var c in categories)
            {
                Console.WriteLine(c.CategoryName);
            }
        }
    }
}
