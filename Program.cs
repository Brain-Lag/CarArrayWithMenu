using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    class Program
    {
        public static void Main(string[] args)
        {
            Car[] array = new Car[0];
            bool flag = true;
            while (flag)
            {
                Console.Write("\n1.Add car.\n2.Seek car.\n3.Show cars.\n4.Exit.");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nChoose action: ");
                Console.ResetColor();
                ConsoleKey input = Console.ReadKey().Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        Menu.AddCar(ref array);
                        break;
                    case ConsoleKey.D2:
                        Menu.SeekCar(ref array);
                        break;
                    case ConsoleKey.D3:
                        Menu.GetInfo(ref array);
                        break;
                    case ConsoleKey.D4:
                        flag = false;
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("\nExit from the program.");
                        Console.ResetColor();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nWrong button.");
                        Console.ResetColor();
                        break;
                }
            }
        }
    }
}