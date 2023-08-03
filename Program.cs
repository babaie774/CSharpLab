using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}!");

            int age = GetAge();
            Console.WriteLine($"You are {age} years old.");

            bool isAdult = CheckIfAdult(age);
            Console.WriteLine($"Are you an adult? - {isAdult}");

            string favoriteColor = GetFavoriteColor();
            Console.WriteLine($"Your favorite color is {favoriteColor}");

            int currentYear = DateTime.Now.Year;
            int birthYear = CalculateBirthYear(age, currentYear);
            Console.WriteLine($"You were born in {birthYear}");
        }

        static int GetAge()
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            return age;
        }

        static bool CheckIfAdult(int age)
        {
            return age >= 18;
        }

        static string GetFavoriteColor()
        {
            Console.Write("Enter your favorite color: ");
            string favoriteColor = Console.ReadLine();
            return favoriteColor;
        }

        static int CalculateBirthYear(int age, int currentYear)
        {
            return currentYear - age;
        }
    }
}
