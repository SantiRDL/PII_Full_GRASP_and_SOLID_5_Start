using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        private IRecipeFormatter recipeFormatter;

        public FilePrinter(IRecipeFormatter recipeFormatter)
        {
            this.recipeFormatter = recipeFormatter;
        }

        public void PrintRecipe(Recipe recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }
}