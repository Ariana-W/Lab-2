/*This Program will allow the user to enter a number in between 1 and 100 and display 
  associated result based on the integer range enetered*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            bool onlyBool; 
     
            Console.WriteLine("Hello User! What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Hello " + userName + "!");
            Console.WriteLine();
            Console.WriteLine("Welcome to the decision making process challenge");
            Console.WriteLine();

            Console.WriteLine(userName + " " + "Please enter positive integers between 1 and 100");

            i = int.Parse(Console.ReadLine());
            Console.WriteLine();


            if ( i < 1 || i > 100)
            {
                Console.WriteLine(userName + " " +", you did not follow the instructions. Please enter positive values between 1 and 100. Please try again!");
                onlyBool = false;
            } 
                

            Console.WriteLine();


            if ( i % 2 !=0  )
            {
            Console.WriteLine(i + " " + " is an Odd number");
            }

            if ( i % 2 ==0 && i < 25 && i > 2)
            {
                Console.WriteLine(i + " " + " is an Even number and less than 25");
            }

            if (i % 2 == 0 && i < 60 && i > 26)
            {
                Console.WriteLine(i + " " + " is an Even number");
            }

            if (i % 2 == 0 && i > 60)
            {
                Console.WriteLine(i + " " + " is an Even number");
            }

            if (i % 2 != 0  && i > 60)
            {
                Console.WriteLine(i + " " + " is an Odd number");
            }

            else if ( i == 2)
            {
                Console.WriteLine(" is an Even number!");                  
            }

        }
    }
}
