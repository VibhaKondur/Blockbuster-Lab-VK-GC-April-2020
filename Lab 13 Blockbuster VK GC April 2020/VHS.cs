using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13_Blockbuster_VK_GC_April_2020
{
    class VHS : MovieAbstract
    {

        //Create a child class of Movie called VHS and code the following:
        //A property called CurrentTime
        public int CurrentTime { get; set; } = 0;

        //overloaded constructor
        public VHS(string title, Genre category, int runtime, List<string> scenes) : base(title, category, runtime, scenes)
        {

        }

        //A method called Play() that plays the scene at the current time and then increments CurrentTime
        public override void Play()
        {
            string scene = Scenes[CurrentTime];
            Console.WriteLine(scene);
            CurrentTime++;
        }

        //A method called Rewind() that returns nothing and sets CurrentTime = 0;
        public void Rewind()
        {
            CurrentTime = 0;
        }
    }
}
