using System;

namespace AbstractExample.Models
{
    public class Fish : Animal
    {
        public Fish(string name)
        {
            Name = name;
        }

        public Fish()
        {
            Name = "Martin";
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"{Name} says glub glub");
        }
        public override void Sleep()
        {
            Console.WriteLine("Gllglglglll");
        }
        
    }
}