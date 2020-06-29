using System;
using System.Collections.Generic;

namespace braintrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        static void menu()
        {
            Console.WriteLine("┌---------------------┐");
            Console.WriteLine("| MAIN MENU           |");
            Console.WriteLine("| 1 - LEVELS          |");
            Console.WriteLine("| 2 - CUSTOM SETTINGS |");
            Console.WriteLine("| 3 - EXIT GAME       |");
            Console.WriteLine("└---------------------┘");
            string mm1;
            mm1 = Console.ReadLine();
            if(mm1 == "1")
            {
                Console.Clear();
                levels();
            }
            if(mm1 == "2")
            {
                Console.Clear();
                customSettings();
            }
            if (mm1 == "3")
            {
                Environment.Exit(0);
            }

        }
        static void levels()
        {
            Console.WriteLine("┌------------------------------------┐");
            Console.WriteLine("| LEVELS                             |");
            Console.WriteLine("| 0 - MAIN MENU                      |");
            Console.WriteLine("| 1 - 5 numbers, range 10, time 10s  |");
            Console.WriteLine("| 2 - 7 numbers, range 12, time 10s  |");
            Console.WriteLine("| 3 - 10 numbers, range 12, time 10s |");
            Console.WriteLine("| 4 - 15 numbers, range 20, time 15s |");
            Console.WriteLine("| 5 - 20 numbers, range 50, time 17s |");
            Console.WriteLine("└------------------------------------┘");
            string l1;
            l1 = Console.ReadLine();
            if (l1 == "0")
            {
                Console.Clear();
                menu();
            }
            if (l1 == "1")
            {
                game();
            }
            if (l1 == "2")
            {
                Console.Clear();
                customSettings();
            }
            if (l1 == "3")
            {
                Environment.Exit(0);
            }
        }
        static void customSettings()
        {
            Console.WriteLine("┌------------------------------------┐");
            Console.WriteLine("| LEVELS                             |");
            Console.WriteLine("| 0 - MAIN MENU                      |");
            Console.WriteLine("| 1 - gh46436346346, time 10s  |");
            Console.WriteLine("| 3 - 10 numbers, range 12, time 10s |");
            Console.WriteLine("| 4 - 15 numb352523time 17s |");
            Console.WriteLine("└------------------------------------┘");
        }
        static void game()//int numbers, int range, int time
        {
            List<int> randomlyNumbers = new List<int>();
            Random rnd = new Random();
            for (int ctr = 1; ctr <= 10; ctr++)
                randomlyNumbers.Add(rnd.Next(10));//do tąd działa
            foreach(item in randomlyNumbers)
            {
                Console.WriteLine(item); ////////////////////////////////////////////tu skooczylem
            }

        }
    }
}
