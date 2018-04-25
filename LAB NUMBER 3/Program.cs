using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_NUMBER_3
{
    class Program
    {
        static void Main(string[] args)
        {

            bool userContinue = true;
            while (userContinue == true)
            {

                Console.WriteLine("Please what is your name? ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter a number between 1 and 100:");

                string input = Console.ReadLine();

                int x = int.Parse(input);

                Console.WriteLine();

                if (x % 2 != 0)
                {


                    Console.WriteLine(x + ", Odd.");
                }
                else if (x % 2 == 0 && x >= 2 && x <= 25)
                {


                    Console.WriteLine("Even and less than 25.");

                }

                else if (x % 2 == 0 && x >= 26 && x <= 60)
                {

                    Console.WriteLine("Even.");

                }

                else if (x % 2 == 0 && x > 60)
                {

                    Console.WriteLine(x + ", even.");

                }

                else if (x % 2 == 1 && x > 60)
                {

                    Console.WriteLine(x + ", Odd.");
                }


                Console.WriteLine("Do you want to continue? (y/n)");
                input = Console.ReadLine();

                if (input.ToLower() == "n")
                {
                    userContinue = false;
                    Console.WriteLine(" Bye!");
                }



            }






        }


    }


}

       

    


         
           






        
   

