using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Recipe recipe = new Recipe();
            while (true)
            {
                Console.WriteLine("Enter command (add, scale, reset, clear, exit):");
                string command = Console.ReadLine();
                switch (command)
                {
                    case "add":
                        recipe.AddIngredient();
                        recipe.AddSteps();
                        Console.WriteLine(recipe.ToString());
                        break;
                    case "scale":
                        recipe.ScaleRecipe();
                        Console.WriteLine(recipe.ToString());
                        break;
                    case "reset":
                        recipe.ResetRecipe();
                        Console.WriteLine(recipe.ToString());
                        break;
                    case "clear":
                        recipe.ClearRecipe();
                        break;
                    case "exit":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid command, try again.");
                        break;
                }
            }
        }
    }
}