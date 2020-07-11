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
        //główna funkcja MENU która zbiera wszystkie funkcje i pozwala użytkownikowi na wybór opcji ktora go interesuje
        static void menu()
        {
            Console.WriteLine("┌---------------------┐");
            Console.WriteLine("| MAIN MENU           |");
            Console.WriteLine("| 1 - CAMPAING        |");
            Console.WriteLine("| 2 - LEVELS          |");
            Console.WriteLine("| 3 - CUSTOM SETTINGS |");
            Console.WriteLine("| 4 - HOW TO PLAY     |");
            Console.WriteLine("| 5 - EXIT GAME       |");
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
                howToPlay();
            }
            if (mm1 == "5")
            {
                Environment.Exit(0);
            }

        }
        // funkcja KAMPANIA odpowiada za tryb kampanii, ktory polega na przechodzeniu poziomow po kolei
        // tzn jesli przejdziemy level 1 automatycznie odpali się level 2 itd
        // program nie zapisuje w jakim momęcie skończyliśmy rozgrywkę, dlatego za kazdym razem jak przegramy
        // musimy zaczynać od nowa (tryb kampanii)
        // w trybie kampanii jest ustawione 5 poziomów które mozemy przejsć
        // tryb mozna w bardzo łatwy sposów rozszerzyć dopisując w miejscu gdzie jest //*** funkcje game() 
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
                //***    <-- (odnośnik do opisu)
                menu();
            }
        }
        //funkcja levels odpowiada za wyświetlenie dostępnych poziomów
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
        //funkcja CUSTONSETTING pozwala nam na konfigurowanie gry w takie sposób jaki chcemy
        // mozemy wybrac : ilosć liczb, zakres liczb i czas w jakim będą wyświetlane
        static void customSettings()
        {
            Console.WriteLine("┌----------------------------------------------┐");
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
            if (numOfNum > 1000 || rangeOfNum > 1000 || viewtime < 5)
            {
                Console.Clear();
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("         ERROR !!!! -->>> enter a smaller range of numbers");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");

            }
            else
            {
                Console.Clear();
                game(numOfNum, rangeOfNum, viewtime);
            }

        }
        // funkcja GAME jest najważniejszą funkcją w grze
        // odpowiada ona za część logiczną gry
        // została ona napisana w bardzo intuicyjny sposób co pozwala w dalszym etapie na prostą konfigurację gry
        // do funkcji wprowadzamy ilosc liczb ( zmienna numbers), zakres liczb (zmienna range), czs(zmienna time)
        // funkcja losuje randomowe liczby i wrzuca je do listy (randomlyNumbers) a następnie wyswietla na ekranie w odpowiednim czasie
        // jesli gracz poprawnie/niepoprawnie doda wyswietlane liczby program go o tym powiadomi ,
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
        // funkcja HOWTOPLAY opisuje gre
        static void howToPlay()
        {
            Console.Clear();
            Console.WriteLine("┌----------------------------------------------┐");
            Console.WriteLine("| 0 - BACK TO MAIN MENU                        |");
            Console.WriteLine("|                                              |");
            Console.WriteLine("| HOW TO PLAY?                                 |");
            Console.WriteLine("|                                              |");
            Console.WriteLine("| Welcome to The author's application / game,  |");
            Console.WriteLine("| which consists in displaying random numbers  |");
            Console.WriteLine("| by the komupter, and then adding them        |");
            Console.WriteLine("| by the player.                               |");
            Console.WriteLine("|                                              |");
            Console.WriteLine("| There are 3 modes in the game:               |");
            Console.WriteLine("| -CAMPAING                                    |");
            Console.WriteLine("| -LEVELS                                      |");
            Console.WriteLine("| -CUSTOM SETTINGS                             |");
            Console.WriteLine("|                                              |");
            Console.WriteLine("| > Campaign mode is from the                  |");
            Console.WriteLine("|   smallest to the largest                    |");
            Console.WriteLine("| > In the LEVELS section we can choose        |");
            Console.WriteLine("|   the level of difficulty that interests us  |");
            Console.WriteLine("| > CUSTOM SETTINGS allows us to configure     |");
            Console.WriteLine("|   the game in any way we are interested in   | ");
            Console.WriteLine("|   (we can choose the number of numbers,      |");
            Console.WriteLine("|   range of numbers, time in which            |");
            Console.WriteLine("|   they will be displayed)                    |");
            Console.WriteLine("|                                              |");
            Console.WriteLine("|                                              |");
            Console.WriteLine("| WARNING!                                     |");
            Console.WriteLine("| THE NUMBERS CAN REPEAT, so pay attention     |");
            Console.WriteLine("| to the rectangles displayed during the game. |");
            Console.WriteLine("| e.g.                                         |");
            Console.WriteLine("|                                              |");
            Console.WriteLine("| █     █             █                        |");
            Console.WriteLine("| █  5       --->     █  5         ---> (5,5)  |");
            Console.WriteLine("| █                   █     █                  |");
            Console.WriteLine("| etc.                                         |");
            Console.WriteLine("|                                              |");
            Console.WriteLine("| GOOD LUCK!                                   |");
            Console.WriteLine("|                                              |");
            Console.WriteLine("| 0 - BACK TO MAIN MENU                        |");
            Console.WriteLine("└----------------------------------------------┘");
            string htp;
            htp = Console.ReadLine();
            if (htp == "0")
            {
                Console.Clear();
                menu();
            }
        }
    }
}

