using Aggregator;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

public class Program
{
    static void Main()
    {
        UserService userService = new UserService();
        OrderService orderService = new OrderService();
        AggregatorService aggregatorService = new AggregatorService(userService, orderService);

        int userId = 1;
        UserInfo userInfo = aggregatorService.GetUserInfo(userId);

        if (userInfo != null)
        {
            Console.WriteLine($"User: {userInfo.User.Name}");
            Console.WriteLine("Orders:");
            foreach (var order in userInfo.Orders)
            {
                Console.WriteLine($"- Order ID: {order.Id}, Product: {order.Product}");
            }
        }
        else
        {
            Console.WriteLine($"User with ID {userId} not found.");
        }
    }
}
