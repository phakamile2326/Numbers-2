using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sumTriple(1, 2));
            Console.WriteLine(sumTriple(3,2));
            Console.WriteLine(sumTriple(2,2));
            Console.ReadKey();
        }

      
        public static int sumTriple(int x, int y)
        {
            return x == y ? (x + y)*3 : x + y;
        }
       
    }
}
