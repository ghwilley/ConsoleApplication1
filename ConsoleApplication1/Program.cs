using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.Make = "Oldsmobile";
            myCar.Model = "Ark";
            myCar.Year = 1989;
            myCar.Color = "Red";

            Car myOtherCar;
            myOtherCar = myCar;

            Console.WriteLine("{0} {1} {2} {3}",
                
                myOtherCar.Make,
                myOtherCar.Model,
                myOtherCar.Year,
                myOtherCar.Color);

            myOtherCar.Model = "98";

            Console.WriteLine("{0} {1} {2} {3}",

                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }
}
