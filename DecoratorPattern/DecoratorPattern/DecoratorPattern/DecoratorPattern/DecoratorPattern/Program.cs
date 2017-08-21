using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("here your program start");

            IModem mod = new Modem();
            LoggingModem log = new LoggingModem(mod);
            string data=    log.Send("hi");
            Console.WriteLine(data);
            Console.ReadKey(true);
        }
    }

}
