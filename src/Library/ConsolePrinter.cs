using System;
using Full_GRASP_And_SOLID.Library;

namespace Library;

public static class ConsolePrinter
{
    public static void PrintRecipe(Recipe recipe)
    
        {
            
            Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
            foreach (Step step in recipe.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }

}

/*En este caso estamos aplicando el primer principio de SOLID el de Single Responsability, el cual propone que cada clase debe 
tener responsabilidad sobre una parte de la funcionalidad proporcionada por el software, en este caso quitamos la responsabilidad 
a las recetas de la clase Recipe de tener que imprimirse a sí mismas y creamos una nueva clase ConsolePrinter que tiene la única 
responsabilidad de imprimir las recetas.*/