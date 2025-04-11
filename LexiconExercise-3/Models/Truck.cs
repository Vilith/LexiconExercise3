using LexiconExercise_3.Interfaces;
using LexiconExercise_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise_3
{
    public class Truck : Vehicle, ICleanable
    {
        public int CargoCapacity { get; set; }
        public Truck(string brand, string model, int year, double weight, int capacity)
            : base(brand, model, year, weight)
        {
            CargoCapacity = capacity;
        }

        public override void StartEngine()
        {
            Console.WriteLine("Truck: Engine rumbles to life");
        }

        public override void Stats()
        {
            Console.WriteLine($"Truck - {Brand} {Model} ({Year}), {Weight}kg, Cargo: {CargoCapacity}kg");
        }

        public void Clean()
        {
            Console.WriteLine("Washing the truck");
        }
    }
}
