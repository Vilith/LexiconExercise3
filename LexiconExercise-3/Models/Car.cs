using LexiconExercise_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise_3.Models
{
    public class Car : Vehicle, ICleanable
    {
        public int NumberOfDoors { get; set; }

        public Car(string brand, string model, int year, double weight, int numberOfDoors)
            : base(brand, model, year, weight)
        {
            NumberOfDoors = numberOfDoors;
        }

        public override void StartEngine()
        {
            Console.WriteLine("Car engine started. Vroom!");
        }

        public override void Stats()
        {
            Console.WriteLine($"Car: {Brand} {Model} ({Year}), {Weight}kg, Doors: {NumberOfDoors}");
        }

        public void Clean()
        {
            Console.WriteLine("Car is being cleaned.");
        }
    }
}
