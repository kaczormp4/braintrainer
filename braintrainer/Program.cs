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
            Console.WriteLine("| 1 - CAMPAING        |");
            Console.WriteLine("| 2 - LEVELS          |");
            Console.WriteLine("| 3 - CUSTOM SETTINGS |");
            Console.WriteLine("| 4 - EXIT GAME       |");
            Console.WriteLine("└---------------------┘");
            string mm1;
            mm1 = Console.ReadLine();
            if (mm1 == "1")
            {
                Console.Clear();
                campaign();
            }
            if (mm1 == "2")
            {
                Console.Clear();
                levels();
            }
            if(mm1 == "3")
            {
                Console.Clear();
                customSettings();
                menu();
            }
            if (mm1 == "4")
            {
                Environment.Exit(0);
            }

        }
        static void campaign()
        {
            Console.WriteLine("┌---------------------┐");
            Console.WriteLine("| CAMPAING            |");
            Console.WriteLine("| 0 - MAIN MENU       |");
            Console.WriteLine("| 1 - START CAMPAING  |");
            Console.WriteLine("└---------------------┘");
            string c1;
            c1 = Console.ReadLine();
            if (c1 == "0")
            {
                Console.Clear();
                menu();
            }
            if (c1 == "1")
            {
                Console.Clear();
                game(5, 10, 10);
                game(7, 12, 10);
                game(10, 12, 10);
                game(15, 20, 15);
                game(20, 50, 17);
                menu();
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
                game(5,10,10);
                menu();
            }
            if (l1 == "2")
            {
                Console.Clear();
                game(7, 12, 10);
                menu();
            }
            if (l1 == "3")
            {
                Console.Clear();
                game(10, 12, 10);
                menu();
            }
            if (l1 == "4")
            {
                Console.Clear();
                game(15, 20, 15);
                menu();
            }
            if (l1 == "5")
            {
                Console.Clear();
                game(20, 50, 17);
                menu();
            }
        }
        static void customSettings()
        {
            Console.WriteLine("┌----------------------------------------------┐");////////////////////////////////////CUSTOM
            Console.WriteLine("| CUSTOM SETTINGS                              |");
            Console.WriteLine("| complete the data before you start the game  |");
            Console.WriteLine("| (numbers of numbers, range of numbers, time) |");
            Console.WriteLine("└----------------------------------------------┘");
            string numOfNum0;
            string rangeOfNum0;
            string time0;
            Console.WriteLine("numbers of numbers :");
            numOfNum0 = Console.ReadLine();
            Console.WriteLine("range of numbers :");
            rangeOfNum0 = Console.ReadLine();
            Console.WriteLine("wiew time :");
            time0 = Console.ReadLine();
            int numOfNum;
            int rangeOfNum;
            int viewtime;
            numOfNum = int.Parse(numOfNum0);
            rangeOfNum = int.Parse(rangeOfNum0);
            viewtime = int.Parse(time0);

            Console.Clear();
            game(numOfNum, rangeOfNum, viewtime);
        }
        static void game(int numbers, int range, int time)
        {
            int sumRandom = 0;
            List<int> randomlyNumbers = new List<int>();
            Random rnd = new Random();
            for (int ctr = 0; ctr < numbers; ctr++)
                randomlyNumbers.Add(rnd.Next(range));
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
                if(i % 2 == 0)
                {
                    Console.WriteLine("█     █");
                    Console.WriteLine("█  " + randomlyNumbers[i]);
                    Console.WriteLine("█");
                }
                else
                {
                    Console.WriteLine("█");
                    Console.WriteLine("█  " + randomlyNumbers[i]);
                    Console.WriteLine("█     █");
                }
                
                sumRandom += randomlyNumbers[i];
                Thread.Sleep(time * 1000 / numbers);
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
                Console.WriteLine("Wyświetlane liczby: ");
                for (int i = 0; i < randomlyNumbers.Count; i++)
                {
                    Console.Write(randomlyNumbers[i]+", ");
                }
                Console.WriteLine("                             ");
                Console.WriteLine("                             ");
                Console.WriteLine("                             ");
                Console.WriteLine("                             ");
               // menu();
                return;
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
                Console.WriteLine("Wyświetlane liczby: ");
                for (int i = 0; i < randomlyNumbers.Count; i++)
                {
                    Console.Write(randomlyNumbers[i] + ", ");
                }
                Console.WriteLine("                             ");
                Console.WriteLine("                             ");
                Console.WriteLine("                             ");
                Console.WriteLine("                             ");
                menu();
               // return;
            }
        }
    }
}
