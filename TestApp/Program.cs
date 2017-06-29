using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        public static void value(int num)
        {
            num++;
        }
        public static void reference(ref int num)
        {
            num++;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("test jenkins build 3");
        }
    }
}
