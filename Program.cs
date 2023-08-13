using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlApp1 
{
class Program
{
    static void Main(string[] args) {
        // Console.ReadKey();
        // string Name = "Iman";
        // int a = 1;
        // int b = 2;
        // int c = a + b;
        // Console.WriteLine(c);

        int a;
        int b;
    try {
        Console.WriteLine("inter Number:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("inter Number:");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a+b);
    } catch(FormatException) {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("formatException");
        Console.ResetColor();
    } catch(SqlException) {
        Console.WriteLine("sqlException");
    } catch {
         Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("please just write number");
        Console.ResetColor();
    } finally {
        Console.WriteLine("finished!");
    }
    }
} 
    class Iman 
    {
    }
}
