using LexiconExercise_3.Interfaces;
using LexiconExercise_3.Models;

namespace LexiconExercise_3.Handlers
{
    public class VehicleHandler
    {
        private List<Vehicle> vehicles = new List<Vehicle>();

        public void CreateVehicle(string type, string brand, string model, int year, double weight, int extra)
        {
            try
            {

                Vehicle v;

                if (type == "car")
                {
                    v = new Car(brand, model, year, weight, extra);
                }
                else if (type == "truck")
                {
                    v = new Truck(brand, model, year, weight, extra);
                }
                else if (type == "motorcycle")
                {
                    v = new Motorcycle(brand, model, year, weight, extra == 1);
                }
                else if (type == "scooter")
                {
                    v = new ElectricScooter(brand, model, year, weight, extra);
                }
                else
                {
                    v = null;
                }

                if (v != null)
                {
                    vehicles.Add(v);
                    Console.WriteLine($"{v.GetType().Name} added!");
                }
                else
                {
                    Console.WriteLine("Failed to add vehicle");
                }

                    
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error creating vehicle: {e.Message}");
            }
        }

        public void UpdateVehicle(int index, string brand, string model, int year, double weight)
        {
            if (index < 0 || index >= vehicles.Count) return;
            try
            {
                vehicles[index].Brand = brand;
                vehicles[index].Model = model;
                vehicles[index].Year = year;
                vehicles[index].Weight = weight;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Update error: {e.Message}");
            }
        }

        public void ListVehicles()
        {
            if (vehicles.Count == 0)
            {
                Console.WriteLine("No vehicles listed!");
            }

            foreach (var v in vehicles)
            {
                v.Stats();
                v.StartEngine();
                if (v is ICleanable cleanable) 
                    cleanable.Clean();
            }
        }
    }
}