using System;

namespace HW_5_28_2019
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World");

            Console.WriteLine("So, you want to be a bad ass huh");
            Console.WriteLine("So how bad are ya? 1. Super Bad ass, 2. Very Very Billy Bad ass, 3. Mega Uzumaki Bad ASS");

            string BadASS = Console.ReadLine();

            switch (BadASS)
            {
                case "1":
                    Console.WriteLine(" so you must be Super Bad ass soooo... ");
                    congrats();
                    break;
                case "2":
                    Console.WriteLine(" so you must be Very Very Billy Bad ass");
                    gotit();
                    break;
                case "3":
                    Console.WriteLine(" so you must be a Mega Uzumaki Bad ASS so your sooooo MR.");
                    childsplay();
                    break;
            }


        }
        private static void childsplay ()
        {
            string[] sweetsList = { "ButterFinger", "Kit-Kat", "Snickers", "Hersheys" };

            Console.WriteLine(sweetsList[1]);
            int yums = 0;

            for(int i = 0; i < sweetsList.Length; ++i)
            {
                Console.WriteLine("Do you like {0},{1}?", sweetsList[i], 0);
                Console.WriteLine("y/n");

                string a = Console.ReadLine().ToLower();
                if (a == "y")
                {
                    yums++;
                }
                else
                {
                    Console.WriteLine("No yums");
                }

                Console.WriteLine("yums");

            }
        }
        private static void congrats()
        {
            string[] bestWrestlers = { "Ric Flair", "Dusty Rhodes", "Sting", "Rowdy roddy Piper" };

            Console.WriteLine(bestWrestlers[1]);
            int WCW = 0;

            for (int i = 0; i < bestWrestlers.Length; ++i)
            {
                Console.WriteLine("Do you like {0},{1}?", bestWrestlers[i], 0);
                Console.WriteLine("DOpe/Nope");

                string a = Console.ReadLine().ToLower();
                if (a == "Dope")
                {
                    WCW++;
                }
                else
                {
                    Console.WriteLine("No They are bums");
                }

                Console.WriteLine("Yes, they would kick their A**");

            }
        } public static void gotit()
        {
            int multiply = 10;

            string Multi(int num1)
            {
                return $"String has value:{num1 * multiply++}";
            }
            Console.WriteLine(Multi(7));
            Console.WriteLine(Multi(6));
        }
    }
    
}
