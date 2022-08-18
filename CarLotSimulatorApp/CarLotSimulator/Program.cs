using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            public class Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            public int Year { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
            public string EngineNoise { get; set; }
            public string HonkNoise { get; set; }
            public bool IsDrivable { get; set; }


        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() }
        //The methods should take one string parameter: the respective noise property
        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine(engineNoise);
        }
        public void MakeEngineNoise(string HonkNoise)
        {
            Console.WriteLine(HonkNoise);




            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            var focus = new Car();
            focus.Make = "Ford";
            focus.Model = "focus";
            focus.Year = 2013;
            focus.EngineNoise = "vroom";
            focus.HonkNoise = "quiet";
            focus.IsDrivable = false;

            var hisCar = new Car()
            {
                Year = 2012,
                Make = "ford",
                Model = "F150",
                EngineNoise = "prrrrr",
                HonkNoise = "beeeeeeeeeeep",
                IsDriveable = True
            };

            var herCar = new Car();
            herCar.Make = "Toyota"
                herCar.Model = "highlander"
                herCar.Year = 2018;
            herCar.EngineNoise = "grrrrrrr";
            herCar.HonkNoise = "loud";
            herCar.IsDrivable = true;

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
