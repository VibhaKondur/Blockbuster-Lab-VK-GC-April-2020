using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13_Blockbuster_VK_GC_April_2020
{
    //created abstract Movie class
    abstract class MovieAbstract
    {
        //Create a property for Title that's a string
        public string Title { get; set; }

        //create a property for Category that's a string - Optional: could do Enum
        public Genre Category { get; set; }

        //Create an int property for RunTime (in minutes)
        public int RunTime { get; set; }

        //Create a property for a list of strings called Scenes
        public List<string> Scenes { get; set; }

        //overloaded constructor
        public MovieAbstract(string title, Genre category, int runtime, List<string> scenes)
        {
            Title = title;
            Category = category;
            RunTime = runtime;
            Scenes = scenes;
        }

        //default constructor
        public MovieAbstract()
        {

        }


        //Create an abstract method with no return type called Play()
        //up to child classes to fill in
        public abstract void Play();


        //create a virtual method called PrintInfo() that prints all properties in the class to the console save for the scenes
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Runtime: {RunTime} minutes");
        }

        //Create a method called PrintScenes() that prints all the scenes in the list along with their index
        public void PrintScenes()
        {
            int i = 0;
            foreach(string scene in Scenes)
            {

                Console.WriteLine($"{i} : {scene}");
                i++;
            }
        }
    }
}
