using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// using Microsoft.Data.SqlClient;

namespace Program
{
    class Program {
        static void Main(string[] args) {
            // HelloUser();
            // HelloUser("alireza");
            // Console.WriteLine(Sum(1,2));
            // Console.WriteLine(FullName("alireza","babaei"));
            int sum = MyClass.Sum(1,2);
            Console.WriteLine(sum);

        }
        static void HelloUser() {
            Console.WriteLine("Hello User!");
        }

        static void HelloUser(string name) {
            Console.WriteLine("Hello"+ " " + name + "!");
        }
        

        static int Sum(int a,int b) {
            return a + b;
        }

        static string FullName(string firstName = "ahmad", string lastName = "jalil") {
            return firstName + " " + lastName;
        }
    }
}