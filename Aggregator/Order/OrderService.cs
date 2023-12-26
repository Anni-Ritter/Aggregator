using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregator
{
    public class OrderService
    {
        private static List<Order> orders = new List<Order>
    {
        new Order { Id = 101, UserId = 1, Product = "Product1" },
        new Order { Id = 102, UserId = 2, Product = "Product2" },
        new Order { Id = 103, UserId = 1, Product = "Product3" },
    };

        public List<Order> GetOrdersByUserId(int userId)
        {
            return orders.Where(o => o.UserId == userId).ToList();
        }
    }
}
