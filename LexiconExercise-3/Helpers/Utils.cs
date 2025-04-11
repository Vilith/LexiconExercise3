using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise_3.Helpers
{
    public class Utils
    {
        public string GetValidString(string prompt)
        {
            string input;
            do
            {
                Console.Write(prompt);
                input = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(input));

            return input;
        }


        public int GetValidInt(string prompt)
        {
            int value;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out value)) return value;
                Console.WriteLine("Invalid number");
            }
        }


        public int GetValidYear(string prompt, int min = 1886)
        {
            int max = DateTime.Now.Year;
            int value;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out value) && value >= min && value <= max) return value;
                Console.WriteLine($"Invalid year. Must be between {min} & {max}");
            }
        }

        public double GetValidDouble(string prompt)
        {
            double value;
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out value)) return value;
                Console.WriteLine("Invalid number");
            }
        }
    }
}