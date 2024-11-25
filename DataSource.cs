using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_4_WPF_Coffee
{
    public class DataSource
    {
        public static List<Coffee> Coffees;


        public static void CreateData()
        {
            Coffees = new List<Coffee>()
            { new Coffee() {CoffeeTemperature=Coffee.Temperature.Iced, BeverageName="Coffee", SizeInOunces=16, BeveragePrice=5.99},
             new Coffee() { CoffeeTemperature=Coffee.Temperature.Iced, BeverageName="Coffee", SizeInOunces=8, BeveragePrice=5.99 },
             new Coffee() { CoffeeTemperature=Coffee.Temperature.Hot, BeverageName="Coffee", SizeInOunces=10, BeveragePrice=6.99}
            };

        }
    }
}