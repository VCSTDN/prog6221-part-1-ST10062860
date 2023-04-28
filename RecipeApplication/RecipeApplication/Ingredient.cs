using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApplication
{
    internal class Ingredient
    {
        public string Name { get; set; }
        public float Quantity { get; set; }
        public string Unit { get; set; }

        public Ingredient(string name, float quantity, string unit)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
        }

    }
}
