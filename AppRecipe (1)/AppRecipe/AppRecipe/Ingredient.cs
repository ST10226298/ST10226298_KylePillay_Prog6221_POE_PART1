using System;

namespace AppRecipe
{
    public class Ingredient
    {
        private string ingredientName;
        private int calories;
        private string foodGroup;

        public Ingredient(string ingredientName, double quantity, string unit, int calories, string foodGroup)
        {
            this.ingredientName = ingredientName;
            Quantity = quantity;
            Unit = unit;
            this.calories = calories;
            this.foodGroup = foodGroup;
        }

        public string Name { get; set; } // getters and setter for name
        public double Quantity { get; set; } // getters and setter for quantity
        public string Unit { get; set; } // getters and setter for unit
        public int Calories
        {
            get { return calories; }
            set { calories = value; }
        }
        public string FoodGroup
        {
            get { return foodGroup; }
            set { foodGroup = value; }
        }
    }
}
