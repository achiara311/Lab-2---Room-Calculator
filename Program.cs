using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            //1. Prompt
            Console.WriteLine("Welcome, please enter the length.");
            string lengthOfSnug = Console.ReadLine();
            double lengthNumber1 = double.Parse(lengthOfSnug);

            Console.WriteLine("Please enter width");
            string widthOfSnug = Console.ReadLine();
            double widthNumber2 = double.Parse(widthOfSnug);

            Console.WriteLine("Please enter height.");
            string heightOfSnug = Console.ReadLine();
            double heightOfNumber1 = double.Parse(heightOfSnug);

            //2. Receive
            //Processing
            double areaOfSnug = lengthNumber1 * widthNumber2;
            double perimeterOfSnug = 2 * (lengthNumber1 + widthNumber2);
            double volumeOfSnug = lengthNumber1 * widthNumber2 * heightOfNumber1;
            //Output
            Console.WriteLine("The Area of the Snug is = {0} in, the perimeter is = {1} in, and the volume is = {2} in.", areaOfSnug, perimeterOfSnug, volumeOfSnug);


            Console.WriteLine("Continue? (Y/N)");
            string yes = Console.ReadLine();
            

            if (yes == "Y" || yes == "y")
            {
                Console.WriteLine("Enter the length of the Penthouse.");
                string lengthOfPenthouse = Console.ReadLine();
                double lengthNumber2 = double.Parse(lengthOfPenthouse);

                Console.WriteLine("Please enter width of Penthouse.");
                string widthOfPenthouse = Console.ReadLine();
                double widthOfNumber2 = double.Parse(widthOfPenthouse);

                Console.WriteLine("Please enter the height of the Penthouse.");
                string heightOfPenthouse = Console.ReadLine();
                double heightOfNumber2 = double.Parse(heightOfPenthouse);

                double areaOfPenthouse = lengthNumber2 * widthOfNumber2;
                double perimeterOfPenthouse = 2 * (lengthNumber2 + widthOfNumber2);
                double volumeOfPenthouse = lengthNumber2 * widthOfNumber2 * heightOfNumber2;

                Console.WriteLine("The Area of the Penthouse is = {0} in, the perimeter is = {1} in, and the volume is = {2} in.", areaOfPenthouse, perimeterOfPenthouse, volumeOfPenthouse);
            }

             else
            {
                Console.WriteLine("Ok, goodbye.");
            }


            Console.ReadKey();

        }
    }
}
