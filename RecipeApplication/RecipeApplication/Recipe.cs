using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApplication
{
    internal class Recipe
    {
        private List<Ingredient> ingredients = new List<Ingredient>();
        private List<string> steps = new List<string>();
        private List<Ingredient> originalIngredients = new List<Ingredient>();

        public Recipe()
        {
            originalIngredients = new List<Ingredient>();
        }

        public void AddIngredient()
        {
            Console.WriteLine("Enter number of ingredients:");
            int numIngredients = int.Parse(Console.ReadLine());
            ingredients.Clear();
            originalIngredients.Clear();
            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"Ingredient {i + 1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Quantity: ");
                float quantity = float.Parse(Console.ReadLine());
                Console.Write("Unit: ");
                string unit = Console.ReadLine();
                ingredients.Add(new Ingredient(name, quantity, unit));
                originalIngredients.Add(new Ingredient(name, quantity, unit));
            }
        }

        public void AddSteps()
        {
            Console.WriteLine("Enter number of steps:");
            int numSteps = int.Parse(Console.ReadLine());
            steps.Clear();
            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"Step {i + 1}:");
                string step = Console.ReadLine();
                steps.Add(step);
            }
        }

        public void ScaleRecipe()
        {
            Console.WriteLine("Enter scaling factor (0.5, 2, or 3):");
            float factor = float.Parse(Console.ReadLine());
            foreach (Ingredient ingredient in ingredients)
            {
                float originalQuantity = originalIngredients.Find(i => i.Name == ingredient.Name).Quantity;
                ingredient.Quantity = originalQuantity * factor;
            }
        }

        public void ResetRecipe()
        {
            ingredients.Clear();
            foreach (Ingredient ingredient in originalIngredients)
            {
                ingredients.Add(new Ingredient(ingredient.Name, ingredient.Quantity, ingredient.Unit));
            }
        }

        public void ClearRecipe()
        {
            ingredients.Clear();
            steps.Clear();
            originalIngredients.Clear();
            Console.WriteLine("Recipe data cleared.");
        }

        public override string ToString()
        {
            string recipeString = "Ingredients:\n";
            foreach (Ingredient ingredient in ingredients)
            {
                recipeString += $"{ingredient.Quantity} {ingredient.Unit} {ingredient.Name}\n";
            }
            recipeString += "\nSteps:\n";
            for (int i = 0; i < steps.Count; i++)
            {
                recipeString += $"{i + 1}. {steps[i]}\n";
            }
            return recipeString;
        }
    }

}
