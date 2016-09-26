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
            Car car1 = new Car();
            car1.Make = "Olds";
            car1.Model = "Cutlas";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";
            car2.VIN = "B2";

            Book b1 = new Book();
            b1.Author = "Ronny Talo";
            b1.Title = "Making books go";
            b1.ISBN = "0-00-00-00-0";
            /*
            //ArrayLists are dynamic 
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);

            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
            }
            

            //List<T>
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);

            foreach (Car car in myList)
            {
                Console.WriteLine(car);
            }
            */

            //Dictionary<TKey, TValue>
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);

            Console.WriteLine(myDictionary["B2"].Make);


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
