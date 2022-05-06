using System;

namespace MethodExercise
{
    class Program
    {
        public static int sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;

        }
        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }
        
        public static int divide(int num1, int num2)
        {
            return num1 / num2;
        }

        static void Main(string[] args)
        {

            var amountOfCars = sum(2, 6);
            var blah = Multiply(60, 2, 4);
            var numberOfDucks = divide(12, 6);
            Console.WriteLine("Hello - what is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName} what is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is a pretty color {userName}, What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"I love {animal} too, What is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Thanks {userName}! Here is your profile.");

            Console.WriteLine($"-----------------------------------");

            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite Color: {color}");
            Console.WriteLine($"Favorite Animal: {animal}");
            Console.WriteLine($"Favorite Band: {band}");






        }
    }
}
