using System;
using System.Collections.Generic;
using System.Linq;
using System.text;
using System.Threading.Tasks;

namespace Prog POE Part 1


class Ingredient
    {
        public string Name { get; set; } //Name of the ingredient
        public double Quantity { get; set; }
        public double originalQuantity{ get; set;}

        public string Unit { get; set; }
    }
   class Step
    {
        public string Description { get; set; }
    } 

    class Program
    {
        static void Main(string[] args)
        {
            Recipe recipe = new Recipe();

              while (true)

            // Prompt The user to select from the menu
            Console.Writeline("--------------------------------");
             Console.Writeline("1. Enter recipe details");
              Console.Writeline("2. Display recipe");
               Console.Writeline("3. Scale recipe ");
                Console.Writeline("4. Reset quantities");
                 Console.Writeline("5. Clear all");
                 Console.Wrriteline("6. exit");

                 string choice = Console.Readline();
                 Console.Writeline();

                 switch (choice)
                 }


    class Recipe
    {
        private Ingredient []ingredients{ get; set;}
        private string[]steps{ get; set}
        private Ingredient[]originalQuantity;

        public double Quantity{ get; privateset; }


        public void EnterDetails()
        {
Console.Write("Enter the number of ingrediants"); // Prompt the user to enter number of ingrediens
int numIngredients = int.Parse(Console.Readline());
Console.WriteLine();

//Ingredient object and adding it to array of ingredients
ingredients = new Ingredient[numIngredients];
originalQuantities = new Ingredient[numIngredients];

for (int i = 0; i < numIngredients; i++)

        }

        Console.WriteLine($"Ingredient{i + 1}");
        Console.Wrile("Name: ");
        string name = Console.ReadLine();
        Console.Write("Quantity": );
        double quantity = double quantity = double.Parse(Console.ReadLine());
        Console.Write("Unit of measurement");
        string unit = Console.ReadLine();
        Console.WriteLine();


        //Create an ingredient object and add it to the array of ingredients
        ingredients[i] = new Ingredient(name, quantity, unit);
        originalQuantities[i] = new Ingredient(name, quantity, unit);
        

        public Recipe(int numIngredients, int numSteps)
        {
            ingredients = new Ingredient[numIngredients];
            steps = new Step[numSteps];
        }

        public void AddIngredient(int index, string name, double quantity, string unit)
        {
            ingredients[index] = new Ingredient { Name = name, Quantity = quantity, Unit = unit };
        }

        public void AddStep(int index, string description)
        {
            steps[index] = new Step { Description = description };
        }

        public void DisplayRecipe()
        {
            Console.WriteLine("Ingredients:");
            foreach (Ingredient ingredient in ingredients)

            {
                Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");
            }

            Console.WriteLine();
            Console.WriteLine("Steps: ");
            for (int i = 0; i < steps.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i].}");
            }
        }
        public void ScaleRecipe()
        {
            Console.Write("Enter scaling factor(0.5, or 2, or 3)"); //Prompt the user to enter the scale factor
            double factor = double.Parse(Console.ReadLine());
            Console.WriteLine();
            
            //loop through the scale
            
            for (int i = 0; i < ingredients.Length; i++)
            {
                Ingredient original = originalQuantities[i];
                Ingredient current = ingredients[i];

                double newQuantity = Quantity * factor;
                ingredients[i] new Ingredient{Name = current.Name, Quantity, newQuantity, Unit = current.Unit};

            }
        }

        public void ResetQuantities()
        {
           Console.WriteLine("Do you want to reset quantities to their Origin");
           string resetResponse = Console.ReadLine().ToLower;
           if (resetResponse == yes)
           {
            recipe.ResetQuantities();
            Console.WriteLine("Reset Quantities to their original values");

           }
           
        }

        public void ClearRecipe()
        {
            ingredients = new Ingredient[ingredients.Length];
            steps = new Step[steps.Length];
        }
    }
            for (int i = 0; i < numIngredients; i++)
            {
                Console.Write($"Enter ingredient {i + 1} name: ");
                string name = Console.ReadLine();

                Console.Write($"Enter quantity of {name}: ");
                double quantity = double.Parse(Console.ReadLine());

                Console.Write($"Enter unit for {name}: ");
                string unit = Console.ReadLine();

                recipe.AddIngredient(i, name, quantity, unit);
            }

            for (int i = 0; i < numSteps; i++)
            {
                Console.Write($"Enter step {i + 1} description: ");
                string description = Console.ReadLine();

                recipe.AddStep(i, description);
            }

            Console.WriteLine("\nRecipe created successfully!\n");

            recipe.DisplayRecipe();

            Console.WriteLine("\nDo you want to scale the recipe? (Enter 0.5, 2, or 3)");
            double factor = double.Parse(Console.ReadLine());
            recipe.ScaleRecipe(factor);

            Console.WriteLine("\nScaled Recipe:");
            recipe.DisplayRecipe();

           
            Console.ReadLine();
        }
        
    