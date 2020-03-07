using System;

namespace myFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Sunny's Blues", "James Baldwin");
            book.TheDeets();

            var brother = new Brother("Christian", 8);
            brother.IdentifyMe();

            var car = new Car("Chanel", "Rouge");
            car.FavCar();

            var pet = new Pet("Cash", 1, "bark, bark");
            pet.FavPet();
        }
    }
}
