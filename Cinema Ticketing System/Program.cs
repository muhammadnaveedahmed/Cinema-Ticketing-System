// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! You are in main menue. Please enter number to test functionality.");

            //reads input value
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);

            if (number == 1)
            {
                ManuOne();
            }
            else if (number == 2)
            {
                MenuTwo();
            }
            else if (number == 3)
            {
                ManuThree();
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }

        static void ManuOne()
        {
            Console.WriteLine("Please enter age.");

            var input = Console.ReadLine(); //reads age value
            int age = Convert.ToInt32(input); // converts value into number

            if (age == 0)
            {
                Console.WriteLine("Invalid age.");
            }
            else
            {
                if (age < 20)
                {
                    Console.WriteLine("Youth price: SEK 80");
                }
                else if (age > 64)
                {
                    Console.WriteLine("Pensioner price: SEK 90");
                }
                else
                {
                    Console.WriteLine("Standerd price: SEK 120");
                }

                Console.WriteLine("How many of us are going to cinema?");
                var personCount = Console.ReadLine(); //reads count value
                double totalCost = 0;
                for (int i = 0; i < Convert.ToInt32(personCount); i++)
                {
                    var number = i + 1;
                    Console.WriteLine("Please enter age of " + number);
                    var inputvalue = Console.ReadLine(); //reads age value
                    int ageValue = Convert.ToInt32(inputvalue); // converts value into number

                    var price = getCinemaPrice(ageValue); // get cinema price
                    totalCost = totalCost + price; // add cinema price to total cost value
                }

                Console.WriteLine("Number of people: " + personCount);
                Console.WriteLine("Total cost for the whole party: " + totalCost);
            }
        }

        static void MenuTwo()
        {
            Console.WriteLine("Please enter text.");
            var output = "";
            for (int i = 0; i < 10; i++)
            {
                var input = Console.ReadLine(); //reads input value
                output = output + i + " " + input + ", ";
            }
            Console.WriteLine("Output: " + output);
        }

        static void ManuThree()
        {
            Console.WriteLine("Please enter sentence with atleast 3 words.");
            var input = Console.ReadLine(); //reads input value

            string[] temp = input.Split(' ');
            var thirdWord = temp[2];

            Console.WriteLine("Output: " + thirdWord);
        }

        static double getCinemaPrice(int age)
        {
            double response = 0;

            if (age < 20)
            {
                response = 80;
            }
            else if (age > 64)
            {
                response = 90;
            }
            else
            {
                response = 120;
            }

            return response;
        }
    }
}
