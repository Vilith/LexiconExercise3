using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise_3.Models
{
    public abstract class Vehicle
    {
        private string brand;
        private string model;
        private int year;
        private double weight;

        protected Vehicle(string brand, string model, int year, double weight)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Weight = weight;
        }

        public string Brand
        {
            get => brand;
            set
            {
                if (value.Length < 2 || value.Length > 20)
                    throw new ArgumentException("Brand must be 2-20 characters long");
                brand = value;
            }
        }

        public string Model
        {
            get => model;
            set
            {
                if (value.Length < 2 || value.Length > 20)
                    throw new ArgumentException("Model must be 2-20 characters long");
                model = value;
            }
        }

        public int Year
        {
            get => year;
            set
            {
                if (value < 1886 || value > DateTime.Now.Year)
                    throw new ArgumentException($"Year must be between 1886 and {DateTime.Now.Year}");
                year = value;
            }
        }

        public double Weight
        {
            get => weight;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Weight must be positive");
                weight = value;
            }
        }

        public abstract void StartEngine();
        public abstract void Stats();
    }
}