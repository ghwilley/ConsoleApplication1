﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           // string text = "A class is the most powerful data type in C#. Like a structure, " +
           //            "a class defines the data and behavior of the data type. ";
          //  File.WriteAllText(@"C:\Users\Public\TestFolder\WriteText.txt", text);

            string address = "http://www.google.com";

            WebClient client = new WebClient();
            string reply = client.DownloadString(address);

            Console.WriteLine(reply);

            Console.ReadLine();
        }
    }

}
