using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    internal class Menu
    {
        public static void AddCar(ref Car[] array)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nEnter car information:");
            Console.Write("Mark: ");
            Console.ResetColor();
            string inMark = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Model: ");
            Console.ResetColor();
            string inModel = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Color: ");
            Console.ResetColor();
            string inColor = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Number: ");
            Console.ResetColor();
            string inNumber = Console.ReadLine();
            Car car = new Car(inMark, inModel, inColor, inNumber);
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = car;
        }

        public static void SeekCar(ref Car[] array)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nEnter the characteristics of the vehicle you are looking for:");
            Console.ResetColor();
            string search = Console.ReadLine();
            bool found = false, flag = false;
            foreach (Car item in array)
            {
                if (item.Mark == search || item.Model == search || item.Color == search || item.Number == search)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"\n1. Mark: {item.Mark}.\n2. Model: {item.Model}.\n3. Color: {item.Color}.\n" +
                                      $"4. Number: {item.Number}.");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Is this the right car? Y/N");
                    Console.WriteLine();
                    Console.ResetColor();
                    if (Console.ReadKey().Key == ConsoleKey.Y)
                    {
                        found = true;
                        break;
                    }
                    else
                    {
                        flag = true;
                        continue;
                    }
                }
            }
            if (!found)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nCar not found.");
                Console.ResetColor();
            }

            if (flag)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nThere are no other cars with such characteristics.");
                Console.ResetColor();
            }
        }

        public static void GetInfo(ref Car[] array)
        {
            if (array.Length > 0)
            {
                int num = 1;
                foreach (Car item in array)
                {
                    Console.WriteLine("\nCar number"+ " " + num);
                    Console.WriteLine($"1. Mark: {item.Mark}.\n2. Model: {item.Model}.\n3. Color: {item.Color}.\n" +
                                      $"4. Number: {item.Number}.");
                    num++;
                }

                Console.WriteLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nYou have not added cars.");
                Console.ResetColor();
            }
        }
    }
}
