using System;

///-----------------------------------------------------------------------------
///   Namespace:    L5_Rollin
///   Description:  Roll the dice!
///   Author:       Derek Wolters                
///   Date:         3.30.17
///   Revision History:
///   Name:           Date:        Description:
///-----------------------------------------------------------------------------

namespace L5_Rollin
{
    class Rollin
    {
        static int minNum = 1;
        static int maxNum = 7;
        

        static void Main(string[] args)
        {
            //initialize variables
            bool keepGoing = true;
            
            Console.WriteLine("Try your hand at rolling the die!");           

            while (keepGoing)
            {
                GetReturnInput();

                //exit program               
                if (ExitProgram())
                {
                    Console.WriteLine("Goodbye!");
                    System.Threading.Thread.Sleep(1000);
                    break;
                }
            }
        }

        public static void GetReturnInput()
        {
            Console.WriteLine("Press 'R' to ROLL");
            Random rnd = new Random();

            //initialize variables
            var KP = Console.ReadKey(true);

            //roll the die
            if (KP.Key == ConsoleKey.R)
            {                
                Console.WriteLine("Rolling the die...");
                System.Threading.Thread.Sleep(4000);
                
                CheckRoll(genRandNum(rnd), genRandNum(rnd));
            }
            else
            {
                GetReturnInput();
            }
        }

        public static void CheckRoll(int die1, int die2)
        {
            if(die1 == 1 && die2 == 1)
            {
                Console.WriteLine("You rolled a " + die1 + " & " + die2 +
                    " SNAKE EYES!!");
            }
            else if (die1 == 6 && die2 == 6)
            {
                Console.WriteLine("You rolled a " + die1 + " & " + die2 +
                    " BOX CARS!!");
            }
            else if (die1 == 5 && die2 == 5)
            {
                Console.WriteLine("You rolled a " + die1 + " & " + die2 +
                    " CRAPS!!");
            }
            else
            {
                Console.WriteLine("You rolled a " + die1 + " & " + die2 +
                    "!!");
            }            
        }

        //generate random number
        public static int genRandNum(Random rnd)
        {            
            int randNum = rnd.Next(minNum, maxNum);
            return randNum;
        }

        //exit the program when the user wants to
        public static Boolean ExitProgram()
        {                       
            Console.WriteLine("Do you want to continue? Enter Y or N.");
            var KP = Console.ReadKey(true);

            while (KP.Key != ConsoleKey.N && KP.Key != ConsoleKey.Y)
            {
                Console.WriteLine("Not a vaid answer. Do you want to " +
                    "continue? Enter Y or N.");
                KP = Console.ReadKey(true);
            }

            return KP.Key == ConsoleKey.N ? true : false;
        }
    }
}