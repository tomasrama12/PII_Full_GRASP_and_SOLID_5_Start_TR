
namespace Full_GRASP_And_SOLID
{
    //Se crea una interfaz para que siempre que quiera tener el texto para imprimir, no dependa directamente de recipe.
    //Se aplica DIP
    public interface IText2Print 
    {
        string GetTextToPrint(); 
    }
}