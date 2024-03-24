using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Fruits
    {
        //delcare fields
        private string fruitName;
        private string fruitNutrition;


        public string FruitName
        {
            get { return fruitName; } //get method
            set { fruitName = value; } //set method

        }
        public string FruitNutrition
        {
            get { return fruitNutrition; } //get method
            set { fruitNutrition = value; } //set method

        }

    }
}
