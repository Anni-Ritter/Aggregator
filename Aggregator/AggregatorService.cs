using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregator
{
    public class AggregatorService
    {
        private UserService userService;
        private OrderService orderService;

        public AggregatorService(UserService userService, OrderService orderService)
        {
            this.userService = userService;
            this.orderService = orderService;
        }

        public UserInfo GetUserInfo(int userId)
        {
            User user = userService.GetUserById(userId);
            if (user != null)
            {
                List<Order> orders = orderService.GetOrdersByUserId(userId);
                return new UserInfo { User = user, Orders = orders };
            }
            return null;
        }
    }

    public class UserInfo
    {
        public User User { get; set; }
        public List<Order> Orders { get; set; }
    }
}
