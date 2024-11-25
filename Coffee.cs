using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_4_WPF_Coffee
{
    public class Coffee : Beverage
    {
        public enum Roast
        {
            Light,
            Medium,
            Dark

        }
        public enum Temperature { Hot, Iced }
        public string BrewStrength { get; set; }
        public Roast RoastType { get; set; }
        public Temperature CoffeeTemperature { get; set; }


        public static List<Coffee> AddCoffee(Coffee coffee)
        {
            List<Coffee> Coffees = new List<Coffee>();
            {
                DataSource.Coffees.Add(coffee);

            }

            return Coffees;
        }

        public static List<Coffee> RemoveCoffee(Coffee coffee)
        {
            List<Coffee> Coffees = new List<Coffee>();
            {
                DataSource.Coffees.Remove(coffee);

            }

            return Coffees;
        }

    }
}
