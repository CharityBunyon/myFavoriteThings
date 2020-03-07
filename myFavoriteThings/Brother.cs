using System;
using System.Collections.Generic;
using System.Text;

namespace myFavoriteThings
{
    class Brother
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsFunny { get; set; }

        public Brother(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void IdentifyMe()
        {
            Console.WriteLine($"My name is {Name} and I'm {Age} years old.");
        }
    }
}
