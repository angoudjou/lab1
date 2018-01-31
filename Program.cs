using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //the new concepts here is the introduction og the height of the room in order to calulate the volume
            const string intro = "Welcome to Grand Circus' Room Detail Generator !";

            string width = null, lenght = null, heigth=null ;

            decimal l=0, w=0, area=0, perimeter=0, h=0;
            bool continue_running= true;
            Console.WriteLine(intro);
            try
            {

                Console.WriteLine("Enter the height of the rooms");

                heigth = Console.ReadLine();

                h = Convert.ToDecimal(heigth);
                while (continue_running)
                {
                    Console.WriteLine();
                    Console.WriteLine("Details of a new room");
                    Console.Write("Enter the length of the room:");
                    lenght = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("Enter the width :");
                    width = Console.ReadLine();


                    l = Convert.ToDecimal(lenght);
                    w = Convert.ToDecimal(width);
                    perimeter = 2 * (l + w);
                    area = (l * w);
                    Console.WriteLine("Perimeter : " + perimeter);
                    Console.WriteLine("Area : " + area);
                    Console.WriteLine("Volume: " + l * w * h);
                    Console.Write("Continue ? (Y/N)");
                    continue_running = Console.ReadKey().Key == ConsoleKey.Y;
                }
            }
            catch (FormatException e)
            {

                Console.WriteLine(e.StackTrace);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                Console.ReadKey();

            }
        }
    }
}
