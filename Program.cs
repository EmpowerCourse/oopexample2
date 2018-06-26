using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.FoodStuff;
using ConsoleApp2.Classes;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // string food = "PIZZA";
            // FoodHappiness howSheFelt = BethanyEatsLunch(FoodType.Salad);
            LunchCounter foodReceived = new LunchCounter();
            //Food result = foodReceived.Exchange(7.50m,FoodType.Pizza);
            //Console.WriteLine(result.Price);
            //Console.WriteLine(result.Type);
            //Console.WriteLine("Bethany is now " + howSheFelt);
            Console.WriteLine("Enter how much money you've got:");
            decimal howMuchWeHave = Convert.ToDecimal(Console.ReadLine());
            Food[] options = foodReceived.GetFoodWithinBudget(howMuchWeHave);
            Console.WriteLine("You can buy " + options.Length + " items:");
            foreach (var o in options) {
                Console.WriteLine("You can buy " + o.Name + ", it will cost " + o.Price);
            }
            Console.ReadKey();
        }

        private static FoodHappiness BethanyEatsLunch(FoodType lunch)
        {
            if (lunch == FoodType.Salad)
            {
                return FoodHappiness.Energized;
            }
            return FoodHappiness.Angry;
        }
    }
}
