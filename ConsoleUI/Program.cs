using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * FINISHED - follow all comments!! 
             */

            #region Vehicles

            /*
             * FINISHED - Create an abstract class called Vehicle
             * FINISHED - The vehicle class shall have three string properties Year, Make, and Model
             * FINISHED - Set the defaults to something generic in the Vehicle class
             * FINISHED - Vehicle shall have an abstract method called DriveAbstract with no implementation
             * FINISHED - Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * FINSIHED - Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * FINISHED - Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * FINISHED - Provide the implementations for the abstract methods
             * FINISHED - Only in the Motorcycle class will you override the virtual drive method
            */

            // FINISHED - Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */ //FINISHED

            var chevy = new Car() { HasTrunk = true, Make = "Chevrolet", Model = "SS", Year = 2018 };  
            var motorcycle = new MotorCycle() { HasSideCart = true, Make = "Harley Davison", Model = "Lightning 2", Year = 2015 }; 

            Vehicle sedan = new Car() { Make = "Acura", Model = "LSX", Year = 2008 };
            Vehicle sportscar = new Car() { HasTrunk = false, Make = "Ferari", Model = "F-50", Year = 2001 };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */  //FINISHED

            vehicles.Add(chevy);
            vehicles.Add(motorcycle);
            vehicles.Add(sedan);
            vehicles.Add(sportscar);

            foreach(var ride in vehicles)
                {
                Console.WriteLine($"The method of transportation make - {ride.Make}, model - {ride.Model}, and year - {ride.Year}.");
                ride.DriveVirtual();
                Console.WriteLine("----------------------------------");
                }

            // FINISHED - Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
