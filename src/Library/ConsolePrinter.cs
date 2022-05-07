using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{

    /* La clase ConsolePrinter implementa la interfaz Iprinter
    usando la operacion polimorifica PrintRecipe para imprimir la receta por consola.
    Cumple con SRP ya que no existe mas de una razon de cambio de la clase*/
    public class ConsolePrinter : IPrinter
    { 
        public void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}