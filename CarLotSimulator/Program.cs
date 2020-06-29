using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.

            var allisonsLot = new CarLot();



            //**COMPLETED** Create a seperate class file called Car 
            //**COMPLETED** Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable - COMPLETED
            //**COMPLETED** Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property            


            //Now that the Car class is created we can instanciate 3 new cars
            var allisonsCar = new Car();

            //Set the properties for each of the cars

            //Using Dot Notation
            allisonsCar.Make = "GMC";
            allisonsCar.Model = "Terrain";
            allisonsCar.Year = 2019;
            allisonsCar.EngineNoise = "vroom";
            allisonsCar.HonkNoise = "beep";
            allisonsCar.IsDriveable = true;

            
            

            //Object Initializer Syntax
            var cipisCar = new Car()
            {
                Year = 2014,
                Make = "Nissan",
                Model = "Rouge",
                EngineNoise = "...",
                HonkNoise = "meow meow",
                IsDriveable = true
            };

            //Using the constructor to allow parameter values to be placed inside properties
            var dollysCar = new Car(2015, "Tesla", "Cyber Truck", "meeeeoow", "meow meow meow", true);


            allisonsLot.Cars.Add(allisonsCar);
            allisonsLot.Cars.Add(cipisCar);
            allisonsLot.Cars.Add(dollysCar);



            //Call each of the methods for each car
            allisonsCar.MakeEngineNoise(allisonsCar.EngineNoise);
            cipisCar.MakeEngineNoise(cipisCar.EngineNoise);
            dollysCar.MakeEngineNoise(dollysCar.EngineNoise);


            foreach(var car in allisonsLot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }




            //*************BONUS*************//

            // **COMPLETED** Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //**COMPLETED** Create a CarLot class
            //**COMPLETED** It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
