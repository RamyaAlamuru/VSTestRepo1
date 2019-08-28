using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gitexample
{
    class Program
    {
         static void Main(string[] args)
        {
            Program c = new Program();
            c.add(10,20);
        }
        public int add(int a,int b)
        {
            Console.Writeline("Sum is:"+(a+b));
        }
    }
}
