using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.B2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (CustomerDBDataContext dataContext = new CustomerDBDataContext())
            {
                try
                {
                    var query = from order in dataContext.Orders
                                join customer in dataContext.Customers
                                on order.CustomerID equals customer.CustomerID
                                select new
                                {
                                    NameOrder = order.Name,
                                    NameCustomer = customer.Name,
                                };
                    foreach (var result in query)
                    {
                        Console.WriteLine("OrderID: " + result.OrderID + " | CustomerName: " + result.CustomerName);
                    }
                }
            }
        }
    }
}
