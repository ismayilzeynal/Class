using System;
using System.Collections.Generic;
using System.Text;

namespace Class.Models
{
    class Car:Vehicle
    {
        //fields
        public string Brand;
        public string Model;
        public double FuelCapacity;
        public double FuelFor1Km;
        public double CurrentFuel;

        //constructor
        // if color of car not given -> the this code not working. Cause if we do it I have to violete DRY principe and copy paste

        public Car(int Year, string Color, string Model, string Brand, double FuelFor1Km, double FuelCapacity) : base(Year, Color)
        {
            this.Model = Model;
            this.Brand = Brand;
            this.FuelFor1Km = FuelFor1Km;
            this.FuelCapacity = FuelCapacity;
        }

        public Car(int Year, string Color, string Model, string Brand, double FuelFor1Km, double FuelCapacity, double CurrentFuel) : this(Year, Color, Model, Brand, FuelFor1Km, FuelCapacity)
        {
            this.CurrentFuel = CurrentFuel;
        }

        //methods
        public void ShowInfo()
        {
            Console.WriteLine($" Brand: {Brand} \n Model: {Model} \n Fuel Capacity: {FuelCapacity} \n Fuel for 1km: {FuelFor1Km}L \n Current Fuel: {CurrentFuel}");
        }

        public double Drive(int Distance)
        {
            this.CurrentFuel = this.CurrentFuel - Distance * this.FuelFor1Km;
            if (CurrentFuel >= 0)
                return this.CurrentFuel;
            else
                return -1;
        }

    }
}
