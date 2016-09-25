using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        private static string k = "";

        static void Main(string[] args)
        {
            int r;
            r =  0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                k = i.ToString();
                r = i;
            }
            Console.WriteLine(k);

            HelperMethod();
            Console.ReadLine();
        }

        static void HelperMethod()
        {
            Console.WriteLine("ValueType of K " + k);
        }

    }

}
