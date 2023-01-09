using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foodType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FoodType foodtype = new FoodType("banana", 4, 93, 3);
            Food food = new Food(foodtype, 110);

            Console.WriteLine(food.toStringInGrams());
            Console.ReadKey();
       
        }
    }
}
