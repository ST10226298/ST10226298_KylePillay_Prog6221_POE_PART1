using System;
using System.Collections.Generic;

namespace AppRecipe
{
    public class Recipe
    {
        private string recipeName;

        public Recipe(string recipeName)
        {
            this.recipeName = recipeName;
        }

        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>(); // declares list of ingredients
        public List<Steps> Steps { get; set; } = new List<Steps>(); // declares list of steps
        public Action<string> CaloriesExceeded { get; internal set; }

        public void AddIngredient(Ingredient ingredient)
        {
            Ingredients.Add(ingredient);
        }

        public void AddStep(Steps step)
        {
            Steps.Add(step);
        }

        public void Display()
        {
            Console.WriteLine($"Recipe: {recipeName}");
            Console.WriteLine("Ingredients:");
            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine($"{ingredient.Name}, {ingredient.Quantity} {ingredient.Unit}, {ingredient.Calories} calories, {ingredient.FoodGroup}");
            }
            Console.WriteLine("Steps:");
            foreach (var step in Steps)
            {
                Console.WriteLine(step.Description);
            }
        }

        public void Reset()

        {
            Ingredients.Clear();
            Steps.Clear();
        }

        public void Scale(double factor)
        {
            foreach (var ingredient in Ingredients)
            {
                ingredient.Quantity *= factor;
            }
        }
    }
}
