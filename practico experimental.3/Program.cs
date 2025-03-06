using System;
using System.Collections.Generic;

class Programa
{
    static void Main()
    {
        // Estructura de datos para almacenar equipos y jugadores
        Dictionary<string, List<string>> equipos = new Dictionary<string, List<string>>();
        int opcion;
        
        do
        {
            // Menú interactivo
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Registrar equipo y jugadores");
            Console.WriteLine("2. Mostrar todos los equipos");
            Console.WriteLine("3. Consultar jugadores de un equipo");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    // Registrar equipo y jugadores
                    Console.Write("Ingrese el nombre del equipo: ");
                    string equipo = Console.ReadLine();
                    List<string> jugadores = new List<string>();

                    Console.Write("Ingrese el número de jugadores: ");
                    int numJugadores = int.Parse(Console.ReadLine());

                    for (int i = 0; i < numJugadores; i++)
                    {
                        Console.Write($"Ingrese el nombre del jugador {i + 1}: ");
                        jugadores.Add(Console.ReadLine());
                    }

                    equipos[equipo] = jugadores;
                    break;

                case 2:
                    // Mostrar todos los equipos y jugadores
                    Console.WriteLine("\nEquipos registrados:");
                    foreach (var item in equipos)
                    {
                        Console.WriteLine($"Equipo: {item.Key}, Jugadores: {string.Join(", ", item.Value)}");
                    }
                    break;

                case 3:
                    // Consultar jugadores de un equipo específico
                    Console.Write("Ingrese el nombre del equipo para consultar: ");
                    string equipoConsulta = Console.ReadLine();

                    if (equipos.ContainsKey(equipoConsulta))
                    {
                        Console.WriteLine($"Jugadores del equipo {equipoConsulta}: {string.Join(", ", equipos[equipoConsulta])}");
                    }
                    else
                    {
                        Console.WriteLine("El equipo no existe.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        } while (opcion != 4);
    }
}

