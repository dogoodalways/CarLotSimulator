using Microsoft.VisualBasic;
using System;
using System.Xml.Schema;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Done - Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created
            //we can instanciate 3 new cars
            // below is the constructor. In the first example
            // its a method that accepts the properties. It does 
            // this because the properties become the parameters of the
            // of the method which is the constructor. 
            // Instantiation 1 using dot notation. 
            CarLot carLot= new CarLot();
            Car YosefsCar = new Car();
            YosefsCar.Make = "Tesla";
            YosefsCar.Model = "ModelS";
            YosefsCar.Year = 2022;
            YosefsCar.EngineNoise = "mmmmm";
            YosefsCar.HonkNoise = "beep";
            YosefsCar.IsDriveable = true;
            carLot.ParkingLot.Add(YosefsCar);
            Console.WriteLine($"The number of cars in the lot is {CarLot.numberOfCars}");
            Console.WriteLine();
            Console.WriteLine();

            Car RivkysCar = new Car()
            {
                Year = 2019,
                Make = "Ford",
                Model = "Transit 350",
                EngineNoise = "vroom",
                HonkNoise = "beep",
                IsDriveable = true,
            };
                   
                carLot.ParkingLot.Add(RivkysCar);
            Console.WriteLine($"The number of cars in the lot is {CarLot.numberOfCars}");
            Console.WriteLine();
            Console.WriteLine();


            // Instantiation 3.
            Car aTradingCar = new Car(2021, "Honda", "Pilot", "vroom", "beep", true);

            CarLot.numberOfCars++;
            Console.WriteLine($"The number of cars in the lot is {CarLot.numberOfCars}");

            
            Console.WriteLine();
            Console.WriteLine();
            


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
