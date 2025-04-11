using LexiconExercise_3.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise_3.Helpers
{
    public static class IndexHelper
    {
        public const string ADD = "1";
        public const string LIST = "2";
        public const string EDIT = "3";
        public const string LIST_CARS = "4";
        public const string QUIT = "0";

        public static void ShowMenu()
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine($"{ADD}: Add Vehicle");
            Console.WriteLine($"{LIST}: List Vehicles");
            Console.WriteLine($"{EDIT}: Edit Vehicle");
            //Console.WriteLine($"{LIST_CARS}"); //For future use
            Console.WriteLine($"{QUIT}: Quit");
        }

        public static void InputHandler(string input, VehicleHandler handler, Utils util)
        {
            switch (input)
            {
                case ADD:
                    CreateVehicle(handler, util);
                    break;

                case LIST:
                    handler.ListVehicles();
                    break;

                case EDIT:
                    UpdateVehicle(handler, util);
                    break;

              //  case LIST_CARS:
              //      break;

                case QUIT:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }

        private static void CreateVehicle(VehicleHandler handler, Utils util)
        {
            Console.WriteLine("Select type (car, truck, motorcycle, scooter): ");
            string type = Console.ReadLine().ToLower();

            string brand = util.GetValidString("Enter brand: ");
            string model = util.GetValidString("Enter model: ");

            int year = util.GetValidYear("Enter year: ");
            double weight = util.GetValidDouble("Enter weight: ");

            //This is a fancier and cleaner if-statement. (Not sure how it works properly yet)
            //if (type == "car") do this etc etc... _ => -1  is the same thing as default in a switch.
            //So if no input matches the criterias it will set "extra = -1" resulting in output: Invalid type
            int extra = type switch
            {
                "car" => util.GetValidInt("Enter number of doors: "),
                "truck" => (int)util.GetValidDouble("Enter cargo capacity (kg): "),
                "motorcycle" => util.GetValidInt("Sidecar? 1 for yes, 0 for no: "),
                "scooter" => util.GetValidInt("Enter battery range (km): "),
                _ => -1
            };

            if (extra != -1)
                handler.CreateVehicle(type, brand, model, year, weight, extra);
            else
                Console.WriteLine("Invalid type");
        }

        private static void UpdateVehicle(VehicleHandler handler, Utils util)
        {
            handler.ListVehicles();

            int index = util.GetValidInt("Index to update: ");
            string brand = util.GetValidString("New brand: ");
            string model = util.GetValidString("New model: ");
            int year = util.GetValidInt("New year: ");
            double weight = util.GetValidDouble("New weight: ");

            handler.UpdateVehicle(index, brand, model, year, weight);
        }
    }
}