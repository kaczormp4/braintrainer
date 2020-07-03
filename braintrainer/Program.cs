using System;
using System.Collections.Generic;
using System.Threading;

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
                Console.Clear();
                game();
            }
            if (l1 == "2")
            {
                Console.Clear();
                customSettings();
            }
            if (l1 == "3")
            {
                Console.Clear();
                Environment.Exit(0);
            }
        }
        static void customSettings()
        {
            Console.WriteLine("┌------------------------------------┐");////////////////////////////////////CUSTOM
            Console.WriteLine("| LEVELS                             |");
            Console.WriteLine("| 0 - MAIN MENU                      |");
            Console.WriteLine("| 1 - gh46436346346, time 10s  |");
            Console.WriteLine("| 3 - 10 numbers, range 12, time 10s |");
            Console.WriteLine("| 4 - 15 numb352523time 17s |");
            Console.WriteLine("└------------------------------------┘");
        }
        static void game()//int numbers, int range, int time
        {
            int sumRandom = 0;
            List<int> randomlyNumbers = new List<int>();
            Random rnd = new Random();
            for (int ctr = 1; ctr < 10; ctr++)
                randomlyNumbers.Add(rnd.Next(10));
            Console.WriteLine(" START ZA 3 SEKUNDY!!! ");
            Console.WriteLine(" 3 ");
            Thread.Sleep(1000);
            Console.WriteLine(" 2 ");
            Thread.Sleep(1000);
            Console.WriteLine(" 1 ");
            Thread.Sleep(1000);
            Console.WriteLine(" LICZ!!!! ");
            Thread.Sleep(2000);
            Console.Clear();

            for ( int i=0; i < randomlyNumbers.Count; i++)
            {
                Console.Clear();
                Console.WriteLine(randomlyNumbers[i]);
                Thread.Sleep(1000);
                
                sumRandom += randomlyNumbers[i];
            }
            Console.Clear();
            Console.WriteLine(" PODAJ WYNIK ");

            string result0;
            result0 = Console.ReadLine();
            int result;
            result = int.Parse(result0);
            if(result == sumRandom)
            {
                Console.Clear();
                Console.WriteLine("                             ");
                Console.WriteLine("                             ");
                Console.WriteLine("     ****           ****     ");
                Console.WriteLine("    *    *         *    *    ");
                Console.WriteLine("     ****           ****     ");
                Console.WriteLine("                             ");
                Console.WriteLine("     *                 *     ");
                Console.WriteLine("       *             *       ");
                Console.WriteLine("         ***********         ");
                Console.WriteLine("                             ");
                Console.WriteLine("                             ");
                Console.WriteLine("BRAWO !!!! twoja odpowiedz (" + sumRandom +") jest POPRAWNA!");
                Console.WriteLine("                             ");
                Console.WriteLine("                             ");
                Console.WriteLine("                             ");
                Console.WriteLine("                             ");
                menu();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("                             ");
                Console.WriteLine("                             ");
                Console.WriteLine("     ****           ****     ");
                Console.WriteLine("    *    *         *    *    ");
                Console.WriteLine("     ****           ****     ");
                Console.WriteLine("                             ");
                Console.WriteLine("         ***********         ");
                Console.WriteLine("       *             *       ");
                Console.WriteLine("     *                 *     ");
                Console.WriteLine("                             ");
                Console.WriteLine("                             ");
                Console.WriteLine("Przykro mi :(  twoja odpowiedz (" + result + ") jest NIEPOPRAWNA! poprawna odpowiedź to: " + sumRandom);
                Console.WriteLine("                             ");
                Console.WriteLine("                             ");
                Console.WriteLine("                             ");
                Console.WriteLine("                             ");
                menu();
            }
        }
    }
}
