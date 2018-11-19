using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("∗∗∗∗∗∗∗∗∗∗∗∗∗∗");
            Console.WriteLine("1---NewGame");
            Console.WriteLine("2---LoadGame");
            Console.WriteLine("3---Options");
            Console.WriteLine("4---Quit");
            Console.WriteLine("∗∗∗∗∗∗∗∗∗∗∗∗∗∗");
            Console.WriteLine();
            Console.WriteLine("Input an option as an integer");
            int selectionNumber = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (selectionNumber == 1)
            {
                Console.WriteLine("Selected 1--NewGame!");
            }
            else if (selectionNumber == 2)
            {
                Console.WriteLine("Selected 2--LoadGame!");
            }
            else if (selectionNumber == 3)
            {
                Console.WriteLine("Selected 3--Options!");
            }
            else if (selectionNumber == 4)
            {
                Console.WriteLine("Selected 4--Quit!");
            }
            else
            {
                Console.WriteLine("Invalid selection!");
            }

            selectionNumber = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (selectionNumber)
            {
                case 1:
                    Console.WriteLine("Selected 1--NewGame!");
                    break;
                case 2:
                    Console.WriteLine("Selected 2--LoadGame!");
                    break;
                case 3:
                    Console.WriteLine("Selected 3--Options!");
                    break;
                case 4:
                    Console.WriteLine("Selected 4--Quit!");
                    break;
                default:
                    Console.WriteLine("Invalid selection!");
                    break;
            }
        }
    }
}
