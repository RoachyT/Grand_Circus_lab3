using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberGiven, userInput, rerun;
            int number;
            Boolean flag = true;
            Console.WriteLine("What is your name?");
            userInput = Console.ReadLine();
            

            do
            {
                Console.WriteLine(userInput +", enter a number between 1 and 100: ");
                numberGiven = Console.ReadLine();
                number = int.Parse(numberGiven);

                if (number % 2 != 0 && number < 60)
                {
                    Console.WriteLine(userInput + ", this number is odd");
                }
                else if (number % 2 == 0 && number >= 2 && number < 25)
                {
                    Console.WriteLine( userInput+ ", this number is Even and Less than 25");
                }
                else if (number % 2 == 0 && number >= 26 && number <= 60)
                {
                    Console.WriteLine( userInput + ", this number is even");
                }
                else if (number % 2 == 0 && number > 60)
                {
                    Console.WriteLine(userInput + "," +  number + " is Even");
                }
                else if (number % 2 != 0 && number > 60)
                {
                    Console.WriteLine(userInput+ "," + number + " is odd");
                }
                else
                {
                    Console.WriteLine( userInput+ ", this number not recognized, please use a whole number between 1 and 100");
                }

                Console.Write(userInput +", do you wish to continue? Y/N ");
                rerun = Console.ReadLine();

                if (rerun.ToLower() == "n")
                {
                    flag = false;
                    Console.WriteLine("Goodbye " + userInput);
                }
             
            }
            while (flag);
 
        }
    }
 }


