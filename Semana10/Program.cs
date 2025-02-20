using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1. Generar 500 ciudadanos ficticios
        HashSet<string> todosLosCiudadanos = new();
        for (int i = 1; i <= 500; i++)
        {
            todosLosCiudadanos.Add($"Ciudadano {i}");
        }

        // 2. Generar 75 ciudadanos vacunados con Pfizer
        HashSet<string> vacunadosPfizer = GenerarVacunados(75);

        // 3. Generar 75 ciudadanos vacunados con AstraZeneca
        HashSet<string> vacunadosAstrazeneca = GenerarVacunados(75);

        // 4. Operaciones de conjuntos
        var noVacunados = todosLosCiudadanos.Except(vacunadosPfizer.Union(vacunadosAstrazeneca));
        var vacunadosAmbasDosis = vacunadosPfizer.Intersect(vacunadosAstrazeneca);
        var soloPfizer = vacunadosPfizer.Except(vacunadosAstrazeneca);
        var soloAstrazeneca = vacunadosAstrazeneca.Except(vacunadosPfizer);

        // 5. Mostrar resultados
        Console.WriteLine("Reporte de Vacunación COVID-19\n");

        MostrarLista("1. Ciudadanos no vacunados:", noVacunados);
        MostrarLista("2. Ciudadanos vacunados con ambas dosis (Pfizer y AstraZeneca):", vacunadosAmbasDosis);
        MostrarLista("3. Ciudadanos vacunados solo con Pfizer:", soloPfizer);
        MostrarLista("4. Ciudadanos vacunados solo con AstraZeneca:", soloAstrazeneca);
    }

    static HashSet<string> GenerarVacunados(int cantidad)
    {
        HashSet<string> vacunados = new();
        Random random = new();
        while (vacunados.Count < cantidad)
        {
            vacunados.Add($"Ciudadano {random.Next(1, 501)}");
        }
        return vacunados;
    }

    static void MostrarLista(string titulo, IEnumerable<string> lista)
    {
        Console.WriteLine($"\n{titulo} ({lista.Count()}):");
        foreach (var ciudadano in lista)
        {
            Console.WriteLine($"- {ciudadano}");
        }
    }
}
