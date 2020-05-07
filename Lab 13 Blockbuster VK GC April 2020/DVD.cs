using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13_Blockbuster_VK_GC_April_2020
{
    class DVD : MovieAbstract
    {

        //Create a child of Movie named DVD with the following code:
        
        public DVD(string title, Genre category, int runtime, List<string> scenes) : base(title, category, runtime, scenes)
        {

        }

        public DVD()
        {

        }

        //A method called Play() that takes no paramaters and is void that will ask the user what scene they'd like to watch
        //prints all available scenes
        //allows the user to select a scene from the list and print it out 
        public override void Play()
        {
            PrintScenes();
            Console.WriteLine("Using the index, please select a scene you'd like to watch");
            string input = Console.ReadLine();
            int pick = int.Parse(input);

            string scene = Scenes[pick];
            Console.WriteLine(scene);
        }
    }
}
