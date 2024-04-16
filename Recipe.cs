using System;

using System.Collections.Generic;



namespace AppRecipe

{

    public class Recipe

    {

        public string Name { get; set; }

        public List<Ingredient> Ingredients { get; set; }

        public List<Steps> Steps { get; set; }



        public Recipe()

        {

            Ingredients = new List<Ingredient>();

            Steps = new List<Steps>();

        }



        public void Display()

        {

            Console.WriteLine("Recipe Ingredients:");

            foreach (var ingredient in Ingredients)

            {

                Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");

            }



            Console.WriteLine("\nRecipe Steps:");

            for (int i = 0; i < Steps.Count; i++)

            {

                Console.WriteLine($"{i + 1}. {Steps[i].Description}");

            }

        }



        public void Scale(double factor)

        {

            foreach (var ingredient in Ingredients)

            {

                ingredient.Quantity *= factor;

            }

        }



        public void Reset()

        {

            // Reset quantities to original values

        }



        public void Clear()

        {

            Ingredients.Clear();

            Steps.Clear();

        }

    }

}



