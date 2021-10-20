using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(IText2Print recipe) //Se le pasa como param el tipo de la interfaz
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}