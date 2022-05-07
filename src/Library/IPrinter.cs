using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    /* Esta interfaz tiene la operacion PrintRecipe para imprimir una receta.
    PrintRecipe es polimorfica ya que es utilizada por dos objetos de distinto tipo y no pregunta por el destino de impresion.
    Cumple con el principio de sustitución de Liskov ya que puede  imprimir por consola
    o en un archivo de texto sin alterar la receta*/
    public interface IPrinter
    {
        void PrintRecipe(Recipe recipe);
    }
}