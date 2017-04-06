using System;

namespace MementoDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Position mousePosition = new Position(10,10,10);
            Console.WriteLine($"Mouse is at Position {mousePosition}");
            mousePosition.X=20;
            mousePosition.Y=20;
            mousePosition.Z=20;
            Console.WriteLine($"Moving Mouse to Position {mousePosition}");
            Console.WriteLine($"Position is Dirty? {mousePosition.IsDirty}");
            Console.WriteLine("Something went Wrong. Reverting to previous position");
            mousePosition.Revert();
            Console.WriteLine($"Mouse is at Position {mousePosition}");
            Console.WriteLine($"Position is Dirty? {mousePosition.IsDirty}");
            
            mousePosition.X=30;
            mousePosition.Y=15;
            mousePosition.Z=20;
            Console.WriteLine($"Moving Mouse to Position {mousePosition}");
            Console.WriteLine($"Mouse is at Position {mousePosition}");
            
        }
    }
}
