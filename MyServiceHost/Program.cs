using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MyServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {

            using (ServiceHost serviceHost = new ServiceHost(typeof(WcfServiceLibrary1.Service1)))
            {
                serviceHost.Open();
                Console.WriteLine("Host open...");
                Console.ReadLine();
            }


        }
    }
}
