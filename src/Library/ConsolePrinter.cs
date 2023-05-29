using System;


namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        private IRecipeFormatter _recipeFormatter;

        public ConsolePrinter(IRecipeFormatter recipeFormatter)
        {
            _recipeFormatter = recipeFormatter;
        }

        public void PrintRecipe(Recipe recipe)
        {
            string formattedRecipe = _recipeFormatter.Format(recipe);
            Console.WriteLine(formattedRecipe);
        }
    }
}