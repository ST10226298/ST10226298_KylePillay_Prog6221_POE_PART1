using System;

namespace AppRecipe
{
    // Main class for user interaction
    class Program
    {
        static void Main(string[] args)
        {
            RecipeBook recipeBook = new RecipeBook();
            while (true)
            {
                Console.WriteLine("Recipe Application:");
                Console.WriteLine("1. Add a new recipe");
                Console.WriteLine("2. Display all recipes");
                Console.WriteLine("3. Display a recipe");
                Console.WriteLine("4. Scale a recipe");
                Console.WriteLine("5. Reset a recipe");
                Console.WriteLine("6. Clear all recipes");
                Console.WriteLine("7. Exit");

                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddRecipe(recipeBook);
                        break;
                    case "2":
                        recipeBook.DisplayAllRecipes();
                        break;
                    case "3":
                        DisplayRecipe(recipeBook);
                        break;
                    case "4":
                        ScaleRecipe(recipeBook);
                        break;
                    case "5":
                        ResetRecipe(recipeBook);
                        break;
                    case "6":
                        recipeBook.Recipes.Clear();
                        Console.WriteLine("All recipes have been cleared.");
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddRecipe(RecipeBook recipeBook)
        {
            Console.Write("Enter the name of the recipe: ");
            var recipeName = Console.ReadLine();
            Recipe recipe = new Recipe(recipeName);
            recipe.CaloriesExceeded += message => Console.WriteLine(message);

            Console.Write("Enter the number of ingredients: ");
            var numIngredients = int.Parse(Console.ReadLine());
            for (int i = 0; i < numIngredients; i++)
            {
                Console.Write("Enter the name of the ingredient: ");
                var ingredientName = Console.ReadLine();
                Console.Write("Enter the quantity: ");
                var quantity = double.Parse(Console.ReadLine());
                Console.Write("Enter the unit of measurement: ");
                var unit = Console.ReadLine();
                Console.Write("Enter the number of calories: ");
                var calories = int.Parse(Console.ReadLine());
                Console.Write("Enter the food group: ");
                var foodGroup = Console.ReadLine();

                var ingredient = new Ingredient(ingredientName, quantity, unit, calories, foodGroup);
                recipe.AddIngredient(ingredient);
            }

            Console.Write("Enter the number of steps: ");
            var numSteps = int.Parse(Console.ReadLine());
            for (int i = 0; i < numSteps; i++)
            {
                Console.Write("Enter the step description: ");
                var stepDescription = Console.ReadLine();
                Steps step = new Steps(stepDescription);
                recipe.AddStep(step);
            }

            recipeBook.AddRecipe(recipe);
        }

        static void DisplayRecipe(RecipeBook recipeBook)
        {
            Console.Write("Enter the name of the recipe to display: ");
            var recipeName = Console.ReadLine();
            var recipe = recipeBook.GetRecipeByName(recipeName);
            if (recipe != null)
            {
                recipe.Display();
            }
            else
            {
                Console.WriteLine("Recipe not found.");
            }
        }

        static void ScaleRecipe(RecipeBook recipeBook)
        {
            Console.Write("Enter the name of the recipe to scale: ");
            var recipeName = Console.ReadLine();
            var recipe = recipeBook.GetRecipeByName(recipeName);
            if (recipe != null)
            {
                Console.Write("Enter the scaling factor (0.5, 2, 3): ");
                var factor = double.Parse(Console.ReadLine());
                recipe.Scale(factor);
                Console.WriteLine("Recipe scaled successfully.");
            }
            else
            {
                Console.WriteLine("Recipe not found.");
            }
        }

        static void ResetRecipe(RecipeBook recipeBook)
        {
            Console.Write("Enter the name of the recipe to reset: ");
            var recipeName = Console.ReadLine();
            var recipe = recipeBook.GetRecipeByName(recipeName);
            if (recipe != null)
            {
                recipe.Reset();
                Console.WriteLine("Recipe reset successfully.");
            }
            else
            {
                Console.WriteLine("Recipe not found.");
            }
        }
    }
}


