using System;
namespace ConsoleUI
{
    public class MotorCycle : Vehicle // Non-abstract class
    {
        public bool HasSideCart { get; set; } = true;

        public override void DriveAbstract()
        {
            Console.WriteLine($"The motorcycle is in drive.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"The motorcycle {GetType().BaseType.Name} virtually in drive.");
        }
    }
}
