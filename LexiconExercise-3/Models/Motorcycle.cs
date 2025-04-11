using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise_3.Models
{
    public class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }

        public Motorcycle(string brand, string model, int year, double weight, bool hasSidecar)
            : base(brand, model, year, weight)
        {
            HasSidecar = hasSidecar;
        }


        public override void StartEngine()
        {
            Console.WriteLine("Motorcycle engine starts with a roar!");
        }

        public override void Stats()
        {
            Console.WriteLine($"Motorcycle: {Brand} {Model} ({Year}), {Weight}kg, Sidecar: {(HasSidecar ? "Yes" : "No")}");
        }
    }
}
