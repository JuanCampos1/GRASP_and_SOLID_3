using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{

    /* La clase FilePrinter implementa la interfaz Iprinter
    usando la operacion polimorifica PrintRecipe para imprimir la receta en un archivo de texto.
    Cumple con SRP ya que no existe mas de una razon de cambio de la clase*/
    public class FilePrinter : IPrinter
    { 
        public void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}