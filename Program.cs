using System;

// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// using Microsoft.Data.SqlClient;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // HelloUser();
            // HelloUser("alireza");
            // Console.WriteLine(Sum(1,2));
            // string fullName = FullName.FullNameGenerator();
            // Console.WriteLine(fullName);
            // Car pride = new Car();
            // pride.CarName = "pride";
            // pride.CarSpeed = 120;
            // pride.CarModel = "sipa";
            // Console.WriteLine(pride.CarName);
            Person alireza = new Person(0, "alireza", "babaei");
            Console.WriteLine(alireza.name);
        }

        static void HelloUser()
        {
            Console.WriteLine("Hello User!");
        }

        static void HelloUser(string name)
        {
            Console.WriteLine("Hello" + " " + name + "!");
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
