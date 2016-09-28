using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] names = { "Bob", "Steve", "Brian", "Chuck" };
            //Object initializer syntax

           // Car car1 = new Car() { Make = "BMW", Model = "750", VIN = "C3" };
           // Car car2 = new Car() { Make = "Toyota", Model = "Carola", VIN = "E4" };

            // Collection initializer
            List<Car> myList = new List<Car>(){
                new Car { Make = "olds", Model = "Stea", VIN = "1029" },
                new Car { Make = "Nissa", Model = "Ult", VIN = "F6" },
                new Car { Make = "Totoyoo", Model = "Taho", VIN = "E4" },
                new Car { Make = "BMW", Model = "Wagon", VIN = "9N" },
                new Car { Make = "Totoyoo", Model = "meat", VIN = "H8" },
                new Car { Make = "BMW", Model = "handle", VIN = "err" },
                new Car { Make = "Totoyoo", Model = "board", VIN = "67" }
            };




            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }

}
