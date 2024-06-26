using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



using System;





namespace AppRecipe

{

    class Program

    {

        static voidpublic string Name { get; set; }
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



Main(s
    
tring[] args)

        {

            Recipe recipe = new Recipe();



            Console.WriteLine("Enter recipe details here:"); // asking user for input



            Console.Write("Enter the amount of ingredients: ");

            int numIngredients = int.Parse(Console.ReadLine());



            for (int i = 0; i < numIngredients; i++)

            {

                Console.Write($"Enter the name of ingredient {i + 1}: ");

                string name = Console.ReadLine();



                Console.Write($"Enter the quantity of ingredient {i + 1}: ");

                double quantity = double.Parse(Console.ReadLine());



                Console.Write($"Enter the measurement of ingredient {i + 1}: ");

                string unit = Console.ReadLine();



                recipe.Ingredients.Add(new Ingredient { Name = name, Quantity = quantity, Unit = unit });

            }



            Console.Write("\nEnter the amount of steps: ");

            int numSteps = int.Parse(Console.ReadLine());



            for (int i = 0; i < numSteps; i++)

            {

                Console.Write($"Enter step {i + 1}: ");

                string description = Console.ReadLine();



                recipe.Steps.Add(new Steps { Description = description });

            }



            Console.WriteLine("\nRecipe Entered:");

            recipe.Display();



            bool running = true;

            while (running)

            {

                Console.WriteLine("\nOptions:");

                Console.WriteLine("1. Scale Recipe");

                Console.WriteLine("2. Reset Quantities");

                Console.WriteLine("3. Clear Recipe");

                Console.WriteLine("4. Exit");



                Console.Write("Enter option: ");

                int option = int.Parse(Console.ReadLine());



                switch (option)

                {

                    case 1:

                        Console.Write("Enter scaling factor (0.5 for half, 2 for double, 3 for triple): ");

                        double factor = double.Parse(Console.ReadLine());

                        recipe.Scale(factor);

                        Console.WriteLine("\nRecipe Scaled:");

                        recipe.Display();

                        break;

                    case 2:

                        recipe.Reset();

                        Console.WriteLine("\nQuantities Reset:");

                        recipe.Display();

                        break;

                    case 3:

                        recipe.Clear();

                        Console.WriteLine("\nRecipe Cleared. Enter new recipe details please:");





                        break;

                    case 4:

                        recipe.Clear();

                        Console.WriteLine("\nRecipe Cleared. Enter new recipe details:");

                        Main(args); // Recursive call to re-enter recipe details

                        break;

                    case 5:

                        running = false;

                        break;

                    default:

                        Console.WriteLine("Invalid option. Please try again.");

                        break;

                }

            }

        }

    }

}

