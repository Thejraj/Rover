using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rover;

namespace Nasa
{
    /// <summary>
    /// Client
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter top right corner of plateu");
            var line = Console.ReadLine();
            if (line != null)
            {
                string[] topRightCoOrdinate = line.Split(' ');
                var plateau = new Plateau(StringToInt(topRightCoOrdinate[0]), StringToInt(topRightCoOrdinate[1]));

                while (true)
                {
                    Console.WriteLine("Enter current position of rover");
                    var readLine = Console.ReadLine();

                    if (readLine != null)
                    {
                        var position = readLine.Split(' ');
                        var currentPosition = new CoOrdinates(StringToInt(position[0]), StringToInt(position[1]));
                        var currentDirection = Direction.N.StringToEnum(position[2]);
            
                        var rover = new RoverObject(currentPosition, currentDirection, plateau);

                        Console.WriteLine("Enter command string");
                        var command = Console.ReadLine();

                        rover.Run(command);
                    }
                    else
                    {
                        Console.WriteLine("Invalid position");
                    }

                    Console.WriteLine("Do you want to exit: (Y/N)");
                    line = Console.ReadLine();
                    if (line == "Y")
                        break;
                }
            }
            Console.ReadKey();
        }

        private static int StringToInt(string str)
        {
            return Convert.ToInt32(str);
        }
    }
}
