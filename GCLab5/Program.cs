using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab5
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Boolean run = true;
            

            while (run == true)
            {
                Console.Clear();
                Console.WriteLine("Recursive Recursion");
                Console.Write("Please enter a number from 1 - 10: ");
                long enteredNumber = long.Parse(Console.ReadLine());


                long number = 1;
                Console.WriteLine("For loop way!");
                Factorial(enteredNumber, number);
                Console.WriteLine("Press any key...");
                Console.ReadKey();

                Console.WriteLine("Using the recursive method now!");

                long Factorial3 = Factorial2(enteredNumber);
                Console.WriteLine(Factorial3);
                Console.WriteLine("Press any key...");
                Console.ReadKey();
                run = Continue();

            }

                
            
        }

        
        public static void Factorial (long numberEntered, long initalNumber)
        {
            
            for (long i = 1; i <= numberEntered; i++)
            {
                initalNumber = initalNumber * i;

                Console.WriteLine(initalNumber);
                 
            }
        }
        
        public static long Factorial2 (long userNumber)
        {
            if (userNumber <= 0)
            {
                return 0;
            }
            else if (userNumber == 1)
            {
                return 1;
            }
            else return userNumber * Factorial2(userNumber-1);

            
        }
        public static Boolean Continue()
        {
            Boolean goOn;
            Console.WriteLine("Continue? y/n");
            string Answer = Console.ReadLine();
            Answer = Answer.ToLower();
            if (Answer == "y")
            {
                goOn = true;
            }
            else if (Answer == "n")
            {
                goOn = false;
            }
            else
            {
                Console.WriteLine("That is not an accepted answer");
                goOn = Continue();
            }

            return goOn;
        }
    }
}
