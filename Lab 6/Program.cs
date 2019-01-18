using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            bool run = true;
            
            {
                Console.WriteLine("Welcome to the Grand Circus Casino! Roll the dice? (y/n)");
                string roll = Console.ReadLine().ToLower();
                do
                if (roll == "y")
                {
                    
                    run = true;
                    Console.WriteLine("How many sides should each die have?");
                    int sides = int.Parse(Console.ReadLine());
                    while (sides <= 0)
                    {
                        Console.WriteLine("Please enter a number:");
                        sides = int.Parse(Console.ReadLine());
                    }
                    int firstTime, secondTime;
                    count += 1;
                    RandomDice(sides, out firstTime, out secondTime);
                    Console.WriteLine($"Roll {count}{firstTime}{secondTime}");

                    Console.WriteLine("Do you think you have the hot hand? (y/n)");
                    roll = Console.ReadLine();

                }
                else if (roll == "n")
                {
                    Console.WriteLine("Goodbye!");
                    run = false;
                }
                else
                {
                    Console.WriteLine("Invalid entry. Please try again!");
                    run = true;
                }while (run == true);
            } 
        }
        public static void RandomDice(int sides, out int output, out int input1)
        {
            Random crazy = new Random();
            output = crazy.Next(1, sides);
            input1 = crazy.Next(1, sides);
            
        }
    }
}
