using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise_3.Models
{
    public class ElectricScooter : Vehicle
    {
        public int BatteryRange { get; set; }

        public ElectricScooter(string brand, string model, int year, double weight, int batteryRange)
            : base(brand, model, year, weight)
        {
            BatteryRange = batteryRange;
        }

        public override void StartEngine()
        {
            Console.WriteLine("Electric scooter powers on silently.");
        }

        public override void Stats()
        {
            Console.WriteLine($"Scooter: {Brand} {Model} ({Year}), {Weight}kg, Range: {BatteryRange}km");
        }
    }
}