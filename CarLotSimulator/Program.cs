using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property            
            Car myCar = new Car();

            //using dot notation
            myCar.Year = 2013;
            myCar.Make = "Honda";
            myCar.Model = "Accord";
            myCar.IsDriveable = true;
            myCar.EngineNoise = "vrrroom";
            myCar.HonkNoise = "beeeep";
            
            //Object Initializer Syntax
            var RangeRover = new Car()
            {
                Make = "Landrover",
                Model = "Range Rover",
                EngineNoise = "vrrroom",
                HonkNoise = "beeeep",
                Year = 2021
            };
            
            var CarLot = new CarLot()
            {

            };

            //using Constructor to parameter values to be placed inside properties
            var BMW = new Car("BMW", "X5", 2021, "vrrroom");

            myCar.MakeEngineNoise(myCar.EngineNoise);
            RangeRover.MakeEngineNoise("vrrroom");
            BMW.MakeEngineNoise("vrrroom");

            var carList = new List<Car>() {myCar, RangeRover, BMW };
            
            foreach (var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make},{vehicle.Model},{vehicle.Year}");
            }

            var lot = new CarLot();
            lot.Cars.Add(myCar);
            lot.Cars.Add(RangeRover);
            lot.Cars.Add(BMW);

            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}");
            }
            /*
            myCar.Year = 2021;
            myCar.Make = "LandRover";
            myCar.Model = "Range Rover";
            myCar.IsDriveable = true;
            */

            /*
            myCar.Year = 2021;,
            myCar.Make = "BMW";
            myCar.Model = "X5";
            myCar.IsDriveable = true;
            */


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
