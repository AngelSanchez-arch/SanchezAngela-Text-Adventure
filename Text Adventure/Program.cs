﻿using System.ComponentModel.Design;
using System.Numerics;

namespace Text_Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // /r means to go back some rooms
            Console.WriteLine("Hello, To Find your crush!");
            Console.WriteLine("I'm your host, Viola");
            Console.WriteLine("We Have a very special Guest. The amazing, Incredabile, Joe");
            Console.WriteLine("You'll pick between 3 Contestants");
            Console.WriteLine("Amelia  | Bass ");
            //to upper uppercases all lettters
            string input = Console.ReadLine();
            if (input.ToUpper() == "Amelia")
            {
                Console.WriteLine("Amelia, Please stand up");
            }
            //Each one
            else if (input == "Bass")
            {
                Console.WriteLine("Bass, Please stand up");
            }
        }

        //static void 
        // void is a funtion
        //Exicutes lines of code top to bottom
    }
}
