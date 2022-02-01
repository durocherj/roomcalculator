using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to the Room Size Advisor!\n\nPlease enter the length: ");
            double length = double.Parse(Console.ReadLine());
            
            Console.Write("Please enter width: ");
            double width = double.Parse(Console.ReadLine());

            var area = length * width;
            var perim = (length * 2) + (width * 2);

          

            Console.WriteLine("The area of the room will be " + area);
            Console.WriteLine("The perimeter is " + perim);

            if (area <= 250)
            {
                Console.WriteLine("This is a small room.");

            }
            else if (250 < area && area <= 650)
            {
                Console.WriteLine("This is a mid-sized room.");
            }
            else
            {
                Console.WriteLine("That room is a heckin chonker!!!");
            }
        }
    }
}
