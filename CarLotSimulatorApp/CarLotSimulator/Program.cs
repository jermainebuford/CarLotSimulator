using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLot = new CarLot();
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            var firstCar = new Car();
            firstCar.Year = 2020;
            firstCar.Make = "telsa";
            firstCar.Model = "model s";
            firstCar.EngineNoise = "quiet";
            firstCar.HonkNoise = "loud";
            firstCar.IsDriveable = true;
            carLot.ListOfCars.Add(firstCar);
            var secondCar = new Car()
            {
                Year = 2020,
                Make = "lexus",
                Model = "mars",
                EngineNoise = "loud",
                HonkNoise = "quiet",
                IsDriveable = true,
            };
            carLot.ListOfCars.Add(secondCar);
            var thirdCar = new Car(2020, "ford", "mustang", "loud", "loud", true);
            carLot.ListOfCars.Add(thirdCar);
            CarDetails(carLot.ListOfCars);
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
        public static void CarDetails(IEnumerable<Car>cars)
        {
            foreach (var car in cars)
            {
                Console.WriteLine($"we have car thats is {car.Make} {car.Year} {car.Model} {car.EngineNoise}");
            }

        }
    }
}
