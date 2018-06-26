using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.FoodStuff;

namespace ConsoleApp2.Classes
{
    public class LunchCounter
    {
        public LunchCounter()
        {
            AvailableItems = new List<Food>();
            AvailableItems.Add(new Food()
            {
                Type = FoodType.Sandwich,
                Name = "Chicken Salad Sandwich",
                Price = 5.99m
            });
            AvailableItems.Add(new Food()
            {
                Type = FoodType.Salad,
                Name = "Cobb Salad",
                Price = 6.35m
            });
            AvailableItems.Add(new Food()
            {
                Type = FoodType.Sandwich,
                Name = "Reuben",
                Price = 7.50m
            });
        }

        // "Field"
        // public List<Food> AvailableItems;

        // "Property"
        public List<Food> AvailableItems { get; set; }
        //private List<Food> _internalList = new List<Food>();
        //public List<Food> AvailableItems
        //{
        //    get
        //    {
        //        // run this code when they ask for AvailableItems
        //        return _internalList;
        //    }
        //    set
        //    {
        //        // run this code when they ask to set (or change) AvailableItems
        //        _internalList = value;
        //    }
        //}

        public Food[] GetFoodWithinBudget(decimal howMuchWeHaveToSpend)
        {
            //List<Food> itemsThatWeCanAfford = new List<Food>();
            //foreach(Food f in AvailableItems)
            //{
            //    if (f.Price <= howMuchWeHaveToSpend)
            //    {
            //        itemsThatWeCanAfford.Add(f);
            //    }
            //}
            //Food[] result = new Food[itemsThatWeCanAfford.Count];
            //int i = 0;
            //foreach (Food f in AvailableItems)
            //{
            //    result[i] = f;
            //    i++;
            //}
            //return result;
            return (from f in AvailableItems
                    where f.Price <= howMuchWeHaveToSpend
                    select f).ToArray();
        }

        public Food Exchange(decimal payment, FoodType typeOfFood)
        {
            Food orderedItem = new Food();
            orderedItem.Price = payment;
            orderedItem.Type = typeOfFood;
            return orderedItem;
        }
    }
}
