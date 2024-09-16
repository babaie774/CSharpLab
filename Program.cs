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
            Person person = new Person("Alireza","Babaei");
            Console.WriteLine(person);
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
