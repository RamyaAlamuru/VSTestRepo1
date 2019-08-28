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
            c.add();
        }
        public int add()
        {
            int a = 10, b = 20;
            int c = a + b;
            return c;
        }
    }
}
