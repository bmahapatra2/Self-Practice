using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Modem : IModem

    {
        public string Send(string data)
        {
            return "i am your Modem class send function";
        }
    }

    public class LoggingModem : IModem
    {
        private IModem _modem;

        public LoggingModem(IModem modem)
        {
            this._modem = modem;
        }

        public string Send(string data)
        {
            Console.WriteLine(data);

            string output = this._modem.Send("i am  your second class send function");

            return output;
        }
    }

    public interface IModem
    {
        string Send(string data);
    }
}
