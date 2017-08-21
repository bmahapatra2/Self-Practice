using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Delegates
{
    delegate int NumberChange(int a);
    public class MainClass
    {
        public static void Main(string[] args)
        { }

    }


    public class Program
    {
        
        private int _num =10;
        public int Functionality(int x)
        {

            NumberChange n;
            NumberChange nc1 = new NumberChange(this.NumAdd);
            NumberChange nc2 = new NumberChange(this.NumMul);

            n = nc1;
            n += nc2;
            n(x);
            return this.GetNum();

        }

        public int NumAdd(int a)
        {
            _num += a;
            return _num;
        }

        public int NumMul(int a)
        {
            _num *= a;
            return _num;
        }

        public int GetNum()
        {
            return _num;
        }
    }
}
