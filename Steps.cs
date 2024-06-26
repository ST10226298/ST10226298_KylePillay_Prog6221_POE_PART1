using AppRecipe;
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace AppRecipe

{



    class Step
    {
        public string Description { get; set; }

        public Step(string description)
        {
            Description = description;
        }
    }
}


class Recipe
{
    public string Name { get; set; }
    public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    public List<Step> Steps { get; set; } = new List<Step>();
    private List<Ingredient> originalIngredients = new List<Ingredient>();

    public event Action<string> CaloriesExceeded;

    public Recipe(string name)
    {
        Name = name;
    }

    public void AddIngredient(Ingredient ingredient)
    {
        Ingredients.Add(ingredient);
        originalIngredients.Add(new Ingredient(ingredient.Name, ingredient.Quantity, ingredient.Unit, ingredient.Calories, ingredient.FoodGroup));
    }

    public void AddStep(Step step)
    {
        Steps.Add(step);
    }

    public void Display()
    {
        Console.WriteLine($"Recipe: {Name}");
        Console.WriteLine("Ingredients:");
        foreach (var ingredient in Ingredients)
        {
            Console.WriteLine($"- {ingredient.Quantity} {ingredient.Unit} of {ingredient.Name} ({ingredient.Calories} calories, {ingredient.FoodGroup})");
        }

        Console.WriteLine("Steps:");
        for (int i = 0; i < Steps.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Steps[i].Description}");
        }

        int totalCalories = Ingredients.Sum(i => i.Calories);
        Console.WriteLine($"Total Calories: {totalCalories}");

        if (totalCalories > 300)
        {
            CaloriesExceeded?.Invoke($"Warning: The total calories for this recipe exceed 300 calories.");
        }
    }

    public void Scale(double factor)
    {
        Ingredients = originalIngredients.Select(ingredient => ingredient.Scale(factor)).ToList();
    }

    public void Reset()
    {
        Ingredients = new List<Ingredient>(originalIngredients);
    }
}


    
}