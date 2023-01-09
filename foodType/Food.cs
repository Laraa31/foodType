using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foodType
{
    internal class Food
    {
        private FoodType type;
        private double weight;

        public Food(FoodType type, double weight)
        {
            this.type = type;
            this.weight = weight;
        }

        public double Weight { get => weight; }
        internal FoodType Type { get => type;  }

        public String toStringInGrams()
        {
            double puG= (weight * type.Protein) / 100;
            double cuG = (weight * type.Carbs) / 100;
            double fuG =( weight * type.Fat) / 100;
            string ispis = type.Name + ": p-" +puG  + "g, c-" +cuG+ "g, f-" +fuG + "g";
            return ispis;
        }

        public double getProtein()
        {
            double puG = (weight * type.Protein) / 100;
            return puG;
        }

        public double getCarbs()
        {
            double cuG = (weight * type.Carbs) / 100;
            return cuG;
        }

        public double getFat()
        {
            double fuG = (type.Fat *weight)/ 100;
            return fuG;
        }
    }
}
