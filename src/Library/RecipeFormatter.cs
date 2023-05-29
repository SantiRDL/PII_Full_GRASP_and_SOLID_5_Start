namespace Full_GRASP_And_SOLID
{
    public class RecipeFormatter : IRecipeFormatter
    {
        public string Format(Recipe recipe)
        {
            string result = $"Receta de {recipe.FinalProduct.Description}:\n";
            foreach (BaseStep step in recipe.Steps)
            {
                result += step.GetTextToPrint() + "\n";
            }

            result += $"Costo de producción: {recipe.GetProductionCost()}";

            return result;
        }
    }
}
