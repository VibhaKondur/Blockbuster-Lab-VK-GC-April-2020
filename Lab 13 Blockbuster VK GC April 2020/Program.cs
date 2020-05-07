using System;
using System.Collections.Generic;

namespace Lab_13_Blockbuster_VK_GC_April_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Blockbuster blockbuster = new Blockbuster();

            Console.WriteLine("Welcome to GC Blockbuster!");
            Console.WriteLine("Please select a Movie from the list: ");

            blockbuster.CheckOut();

            Console.WriteLine("Do you want to watch the movie? Y/N");

            
        }


    }
}
