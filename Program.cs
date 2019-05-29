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
            Console.WriteLine(" if you really like candy then let me know how much you like it");
            string[] sweetsList = { "ButterFinger", "Kit-Kat", "Snickers", "Hersheys" };

            
            int yums = 0;

            for(int i = 0; i < sweetsList.Length; i++)
            {
                Console.WriteLine("Do you like {0}?", sweetsList[i]);
                Console.WriteLine("yes or no");

                string si = Console.ReadLine().ToLower();
                if (si == "yes")
                {
                    yums++;
                }
                else
                {
                    Console.WriteLine("yeah that stuff is trash");
                }

                Console.WriteLine(yums);

            }
        }
        private static void congrats()
        {
            string[] bestWrestlers = { "Ric Flair", "Dusty Rhodes", "Sting", "Rowdy roddy Piper" };

            
            int WCW = 0;

            for (int i = 0; i < bestWrestlers.Length; i++)
            {
                Console.WriteLine("Do you like {0}?", bestWrestlers[i]);
                Console.WriteLine("Dope or Nope");

                string a = Console.ReadLine().ToLower();
                if (a == "Dope")
                {
                    WCW++;
                }
                else
                {
                    Console.WriteLine("trash");
                }
                Console.WriteLine(WCW);


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
