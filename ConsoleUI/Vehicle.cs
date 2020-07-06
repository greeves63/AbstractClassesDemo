using System;
namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int Year { get; set; } = 1;
        public string Make { get; set; } = "Default Make";
        public string Model { get; set; } = "Default Model";

        public abstract void DriveAbstract(); //Abstract method with no implementation.

        public virtual void DriveVirtual()  //Virtual method with base implementation.
        {
            Console.WriteLine($"The {GetType().Name} virtually is in drive.");
        }
    }
}
