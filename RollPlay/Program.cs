using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollPlay
{
    class Program
    {

        static void Main(string[] args)
        {
            Numbers number = new Numbers();

            // Console.WriteLine("Enter the number of sides your dice has:");
            // int diceSides = Int32.Parse(Console.ReadLine()); //Convert.ToInt32 handle null and returns '0' as output and int.parse is not going to handle NULL and will give a Argument Null Exception

            // Console.WriteLine("Enter the number of times you want to throw your dice:");
            // int numberOfThrows = Convert.ToInt32(Console.ReadLine());

            //// int[] randomNumbers = number.ThrowDice(numberOfThrows);
            // int[] randomNumbers = number.ThrowDice(diceSides, numberOfThrows);
            int[] randomNumbers = number.ThrowDice("6T20");


            Console.WriteLine("The results of throw are:");
            foreach (int rand in randomNumbers)
            {
                Console.WriteLine(rand);
            }
        }
    }
}
