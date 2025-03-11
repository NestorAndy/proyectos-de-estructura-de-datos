using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> catalogo = new List<string>();
        Console.WriteLine("Ingrese 10 títulos de revistas:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Revista {i + 1}: ");
            catalogo.Add(Console.ReadLine());
        }

        while (true)
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Buscar un título (Iterativo)");
            Console.WriteLine("2. Buscar un título (Recursivo)");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            
            string opcion = Console.ReadLine();

            if (opcion == "3") break;

            Console.Write("Ingrese el título a buscar: ");
            string titulo = Console.ReadLine();

            bool encontrado = false;

            if (opcion == "1")
                encontrado = BusquedaIterativa(catalogo, titulo);
            else if (opcion == "2")
                encontrado = BusquedaRecursiva(catalogo, titulo, 0);
            else
                Console.WriteLine("Opción no válida.");

            Console.WriteLine(encontrado ? "Título encontrado" : "Título no encontrado");
        }
    }

    static bool BusquedaIterativa(List<string> catalogo, string titulo)
    {
        foreach (string revista in catalogo)
        {
            if (revista.Equals(titulo, StringComparison.OrdinalIgnoreCase))
                return true;
        }
        return false;
    }

    static bool BusquedaRecursiva(List<string> catalogo, string titulo, int indice)
    {
        if (indice >= catalogo.Count)
            return false;
        if (catalogo[indice].Equals(titulo, StringComparison.OrdinalIgnoreCase))
            return true;
        return BusquedaRecursiva(catalogo, titulo, indice + 1);
    }
}
