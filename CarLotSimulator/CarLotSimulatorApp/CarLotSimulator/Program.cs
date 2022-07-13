using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var newCarLot = new CarLot();
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            var car1 = new Car(1995, "VW", "Tiguan", "vroom", "beep", true);


            var car2 = new Car();
            car2.Year = 2020;
            car2.Make = "ford";
            car2.Model = "f150";
            car2.EngineNoise = "vroom";
            car2.HonkNoise = "honk honk";
            car2.IsDriveable=true;

            var car3 = new Car()
            {
                Year = 1995,
                Make = "jeep",
                Model = "cherokee",
                EngineNoise = "rumble",
                HonkNoise = "beep",
                IsDriveable = true
            };
            newCarLot.ParkingLot.Add(car1);
            newCarLot.ParkingLot.Add(car2);
            newCarLot.ParkingLot.Add(car3);

            foreach (var car in newCarLot.ParkingLot)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
                car.MakeEngineNoise(car.EngineNoise);
                car.MakeHonkNoise(car.HonkNoise);
                Console.WriteLine("--------------------\n");
            }
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
