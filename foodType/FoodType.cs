using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foodType
{
    internal class FoodType
    {
        private static int counter = 0;
        private string name;
        private int protein;
        private int carbs;
        private int fat;

        public FoodType(string name, int protein, int carbs, int fat)
        {
            counter = counter++;
            this.name = name;
            this.protein = protein;
            this.carbs = carbs;
            this.fat = fat;
        }

        public string Name { get { return name; } }
        public int Protein { get { return protein; } }
        public int Carbs { get { return carbs; } }
        public int Fat { get { return fat; } }


        public override string ToString()
        {
            string ispis = name + ": p-" + protein + "%, c-" + carbs + "%, f-" + fat + "% "; 
            return ispis;
        }

        public static int getNumberOfCreatedInstances()
        {
            return counter;
        }
    }

    

}
