using System;
using StoreLib;

namespace StoreUI
{
    internal class LocationMenu : Menu
    {
        private ILocation location;

        public LocationMenu(ILocation location)
        {
            this.location = location;
        }

        public override void Start()
        {
            do
            {
                Console.WriteLine($"\nWelcome to our {location.Name} location!");
                Console.WriteLine("Select from our stock.");
                Console.WriteLine("[0] ...");
                Console.WriteLine("[X] Back to Shop Menu");
                userInput = Console.ReadLine();
            } while (!UserInputIsX());
        }
    }
}