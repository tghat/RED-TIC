using MtrServices.MtrServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtrServices
{
    class Program
    {
        static void Main(string[] args)
        {
            MtrServicesSoapClient myService = new MtrServicesSoapClient();
            Console.Write("Fibonacci (10) = {0}.", myService.Fibonacci(10));
        }
    }
}
