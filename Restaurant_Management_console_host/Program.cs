using Restaurant_Management;
using Restaurant_Management.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_console_host
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (ServiceHost host2 = new ServiceHost(typeof(OrderService)))
                using (ServiceHost host1 = new ServiceHost(typeof(ItemService)))
                using (ServiceHost host = new ServiceHost(typeof(AccountService)))
                {
                    host.Open();
                    Console.WriteLine("AccountService hosted on http://localhost:8080/ @ " + DateTime.Now.ToString());
                    host1.Open();
                    Console.WriteLine("ItemService hosted on http://localhost:8090/ @ " + DateTime.Now.ToString());
                    host2.Open();
                    Console.WriteLine("OrderService hosted on http://localhost:8100/ @ " + DateTime.Now.ToString());
                    Console.ReadLine();

                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}
