using System;
namespace ConsoleUI
{
    public class Car : Vehicle // Non-abstract class
    {
        public Car()
        {
        }

        public bool HasTrunk { get; set; } = true;

        public override void DriveAbstract()
        {
            Console.WriteLine($"The car is in drive.");
        }

    }
}
