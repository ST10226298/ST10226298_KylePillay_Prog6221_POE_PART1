# Recipe App

This is a simple console application that allows users to enter recipe details including ingredients and steps, display the full recipe, scale the recipe by a factor, reset quantities, or clear all data to enter a new recipe.

## Features

- **Enter Recipe Details**: Users can input the number of ingredients and steps, along with their respective details.
- **Display Recipe**: The full recipe, including ingredients and steps, is displayed in a neat format to the user.
- **Scale Recipe**: Users can scale the recipe by a factor of 0.5 (half), 2 (double), or 3 (triple). All ingredient quantities are adjusted accordingly.
- **Reset Quantities**: Users can reset the ingredient quantities to their original values.
- **Clear Recipe**: Users can clear all data to enter a new recipe.
- **No Persistence**: User data is stored in memory only while the software is running, and not persisted between runs.

## Usage

1. Run the `Program.cs` file.
2. Follow the prompts to enter recipe details.
3. Choose from the options presented to view, scale, reset, or clear the recipe.

## Requirements

- .NET Core 3.1 or higher

## Structure

- `Program.cs`: Contains the main entry point and user interface logic.
- `Recipe.cs`: Defines the `Recipe` class with methods to manage the recipe details.
- `Ingredient.cs`: Defines the `Ingredient` class to represent individual ingredients.
- `Steps.cs`: Defines the `Steps` class to represent individual steps in the recipe.

## Author

Kyle PIllay

---

