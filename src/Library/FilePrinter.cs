using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(IText2Print recipe) //Se le pasa como param el tipo de la interfaz
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }
}