using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdultDrive
{
    class Program
    {
        static void Main(string[] args)
        {
            // User enters age
            Console.Write("Please enter your age in years: ");
            String ageString = Console.ReadLine();
            // Convert string to Int
            int age = Convert.ToInt32(ageString);

            // Condition >=16 you can drive
            // Condition >=18 you are an adult
            // Condition < 18 you are not an adult

            if (age >= 16)
            {
                Console.WriteLine("You can drive!");
            }
            if (age >= 18)
            {
                Console.WriteLine("You are an adult!");
            }
            if (age < 18)
            {
                Console.WriteLine("You are not an adult!");
            }
        }
    }
}

