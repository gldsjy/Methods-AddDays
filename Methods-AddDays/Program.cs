using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_AddDays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayNumber = EnterNumber();
            PrintDay(dayNumber);

            int dayToAdd = EnterToAdd();
            PrintDay(dayNumber, dayToAdd);

            Console.ReadKey();
        }

        static int EnterNumber()
        {
            Console.Write("Enter a number between 1 to 7: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static void PrintDay(int dayNumber)
        {
            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("The day is MONDAY");
                    break;
                case 2:
                    Console.WriteLine("The day is TUESDAY");
                    break;
                case 3:
                    Console.WriteLine("The day is WEDNESDAY");
                    break;
                case 4:
                    Console.WriteLine("The day is THURSDAY");
                    break;
                case 5:
                    Console.WriteLine("The day is FRIDAY");
                    break;
                case 6:
                    Console.WriteLine("The day is SATURDAY");
                    break;
                case 7:
                    Console.WriteLine("The day is SUNDAY");
                    break;
                default:
                    Console.WriteLine("Invalid Input.");
                    break;
            }
        }

        static int EnterToAdd()
        {
            Console.Write("Input number to add to the day: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static void PrintDay(int dayNumber, int dayToAdd)
        {
            int finalDay = (dayNumber + dayToAdd - 1) % 7 + 1;

            switch (finalDay)
            {
                case 1:
                    Console.WriteLine("The day is MONDAY");
                    break;
                case 2:
                    Console.WriteLine("The day is TUESDAY");
                    break;
                case 3:
                    Console.WriteLine("The day is WEDNESDAY");
                    break;
                case 4:
                    Console.WriteLine("The day is THURSDAY");
                    break;
                case 5:
                    Console.WriteLine("The day is FRIDAY");
                    break;
                case 6:
                    Console.WriteLine("The day is SATURDAY");
                    break;
                case 7:
                    Console.WriteLine("The day is SUNDAY");
                    break;
                default:
                    Console.WriteLine("Invalid Input.");
                    break;
            }
        }
    }
}

