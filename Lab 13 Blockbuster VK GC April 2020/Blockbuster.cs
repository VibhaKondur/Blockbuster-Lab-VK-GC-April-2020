using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Lab_13_Blockbuster_VK_GC_April_2020
{
    class Blockbuster
    {
        public static List<string> missCongenialityscenes = new List<string>()
        {
            "Sting operation in the restaurant",
            "The talent competition where Grace plays the water glasses",
            "The Miss United States Pageant where the crown is thrown at the statue"
        };

        public static List<string> shawshankRedemptionscenes = new List<string>()
        {
            "Andy is convicted and sentenced to murder",
            "Andy plays opera on the warden's speaker to the whole yard",
            "Andy escapes from prison through the pipes"
        };

        public static List<string> cabinInTheWoodsscenes = new List<string>()
        {
            "Office bunker where scientists are taking bets",
            "Where monsters are unleashed from their holding pens",
            "Leader tells two remaining in the group they need to sacrifice for greater good"
        };

        public static List<string> bridgetJonesDiaryscenes = new List<string>()
        {
            "Turkey Curry buffet where Bridget Jones meets Mark Darcy",
            "Bridget Jones introduces boss at event when microphone wasn't on",
            "Mark Darcy and Daniel Cleaver fight"
        };

        public static List<string> youveGotMailscenes = new List<string>()
        {
           "Meeting in the coffee shop",
           "Meeting at the party",
           "Finally meeting face to face at the end"
        };

        public static List<string> theDarkKnightscenes = new List<string>()
        {
            "Joker robs the bank and gets away using the schoolbuses",
            "Joker kills a man with just a pencil",
            "Harvey Dent and Bruce Wayne try to save Rachel Dawes but don't"
        };

        public List<MovieAbstract> MovieList = new List<MovieAbstract>()
        {
            new VHS("Miss Congeniality", Genre.Comedy, 90, missCongenialityscenes),
            new VHS("Shawshank Redemption", Genre.Drama, 120, shawshankRedemptionscenes),
            new VHS("Cabin in the Woods", Genre.Horror, 90, cabinInTheWoodsscenes),
            new DVD("Bridget Jones's Diary", Genre.Romance, 100, bridgetJonesDiaryscenes),
            new DVD("You've Got Mail", Genre.Comedy, 85, youveGotMailscenes),
            new DVD("The Dark Knight", Genre.Drama, 150, theDarkKnightscenes)
        };

        //default constructor
        public Blockbuster()
        {

        }

        public void PrintMovies()
        {
            for (int i = 0; i < MovieList.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {MovieList[i].Title}");
            }

        }

        public void CheckOut()
        {
            PrintMovies();

            Console.WriteLine("Please select a movie you want to watch: ");
            string input = Console.ReadLine();
            int index = int.Parse(input) - 1;
            MovieList[index].PrintInfo();
        }

        public static bool UserContinue(string message)
        {
            Console.WriteLine(message);
            String Response = Console.ReadLine().ToLower();

            while (Response != "n" && Response != "y")
            {
                Console.WriteLine("Invalid input. Do you want to watch the movie? Y/N");
                Response = Console.ReadLine();
            }

            if (Response == "n")
            {
                Console.WriteLine("No problem. Have a great day!");
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
