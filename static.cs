using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    
    
        internal class staticconst
        {
            static int s;
            int ns;
            static staticconst()
            {
                Console.WriteLine("it is static constructor");

            }

            public staticconst()
            {
                Console.WriteLine("it is nonstatic constructor");

            }

            static void Main(string[] args)
            {
                staticconst obj1 = new staticconst();
                Console.ReadLine();
            }
        }
    

}

