using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace AppRecipe

{

    public class Ingredient

    {

        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
        public int Calories { get; set; }
        public string FoodGroup { get; set; }

        public Ingredient(string name, double quantity, string unit, int calories, string foodGroup)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
            Calories = calories;
            FoodGroup = foodGroup;
        }

        public Ingredient Scale(double factor)
        {
            return new Ingredient(Name, Quantity * factor, Unit, Calories, FoodGroup);
        }
    }
    
}

class Step
{
    public string Description { get; set; }

    public Step(string description)
    {
        Description = description;
    }
}
class Step
{
    public string Description { get; set; }

    public Step(string description)
    {
        Description = description



