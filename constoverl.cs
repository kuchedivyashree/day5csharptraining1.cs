using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class ADD
    {
        int x, y;
        double f;
        string s;

        // 1st constructor
        public ADD(int a, double b)
        {
            x = a;
            f = b;
        }

        //2nd constructor
        public ADD(int a, string b)
        {
            y = a;
            s = b;
        }
        //showing 1st constructor's result
        public void show()
        {
            Console.WriteLine("1st constructor(int+float):{0}", (x + f));
        }
        //showing 2nd constructor's result
        public void show1()
        {
            Console.WriteLine("2nd constructor(int+string):{0}", (s + y));
        }
    }
    class constoverl
    {

    
        static void Main(string[] args)
        {
            ADD g = new ADD(10, 20.2);
            g.show();
            ADD q = new ADD(10, "roll no .is");
            q.show1();
            Console.ReadLine();
        }
    }
}
