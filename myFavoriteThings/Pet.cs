using System;
using System.Collections.Generic;
using System.Text;

namespace myFavoriteThings
{
    class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Speak { get; set; }

        public Pet(string name, int age, string speak)
        {
            Name = name;
            Age = age;
            Speak = speak;
        }

        public void FavPet()
        {
            Console.WriteLine($"My dog's name is {Name} and he's {Age} years old. When he talks to me he says {Speak}.");
        }
    }
}
