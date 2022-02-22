using System;
using AbstractExample.Models;

namespace AbstractExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Which animal do you want to hear?");
            
            Console.WriteLine("1. Pig 2. Dog 3. Fish");
            var choice = Console.ReadLine();

            Animal animal = null;

            if (choice == "1")
            {
                animal = new Pig();
            }
            else if (choice == "2")
            {
                animal = new Dog();
            } else if (choice == "3")
            {
                animal = new Fish();
            }

            animal?.MakeNoise();
            animal?.Sleep();
        }
    }
}
