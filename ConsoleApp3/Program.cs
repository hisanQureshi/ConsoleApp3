using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname= "John";
            string lname = "Doe";
            string fullname = fname + " " + lname;
            Console.WriteLine("Hello, " + fullname);
            Console.WriteLine(fullname.Length);
            Console.WriteLine(fullname.ToUpper());
            Console.WriteLine(fullname.ToLower());
            Console.WriteLine(fullname.Contains("John"));
            Console.WriteLine(fullname.Contains("john"));
            Console.WriteLine(fullname.Contains("Doe"));
            Console.WriteLine(fullname.Contains("doe"));
            Console.WriteLine(fullname.Contains("Jane"));

        }
    }
}
