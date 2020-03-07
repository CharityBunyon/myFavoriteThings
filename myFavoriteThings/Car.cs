using System;
using System.Collections.Generic;
using System.Text;

namespace myFavoriteThings
{
    class Car
    {
        public string Name { get; set; }
        public string Model { get; set; }

        public Car(string name, string model)
        {
            Name = name;
            Model = model;
        }

        public void FavCar()
        {
            Console.WriteLine($"My car name is {Name} and it's a {Model}.");
        }
    }
}
