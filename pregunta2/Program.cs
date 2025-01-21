using System;

namespace InvertirListaEnlazada
{
    // Clase que representa un nodo de la lista
    public class Nodo
    {
        public string Nombre;       // Nombre del pasajero
        public Nodo Siguiente;      // Puntero al siguiente nodo

        public Nodo(string nombre)
        {
            Nombre = nombre;
            Siguiente = null; // Inicialmente, no apunta a ningún nodo
        }
    }

    // Clase que representa la lista enlazada
    public class ListaPasajeros
    {
        public Nodo Cabeza; // Nodo inicial de la lista

        public ListaPasajeros()
        {
            Cabeza = null; // Inicialmente, la lista está vacía
        }

        // Método para agregar un pasajero al final de la lista
        public void AgregarPasajero(string nombre)
        {
            Nodo nuevoNodo = new Nodo(nombre);

            if (Cabeza == null)
            {
                Cabeza = nuevoNodo; // Si la lista está vacía, el nuevo nodo será la cabeza
            }
            else
            {
                Nodo actual = Cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente; // Avanzar hasta el último nodo
                }
                actual.Siguiente = nuevoNodo; // Agregar el nuevo nodo al final
            }
        }

        // Método para invertir la lista de pasajeros
        public void InvertirOrden()
        {
            Nodo anterior = null;
            Nodo actual = Cabeza;
            Nodo siguiente = null;

            while (actual != null)
            {
                siguiente = actual.Siguiente; // Guardar el siguiente nodo
                actual.Siguiente = anterior;  // Invertir el puntero
                anterior = actual;            // Mover "anterior" al nodo actual
                actual = siguiente;           // Avanzar al siguiente nodo
            }

            Cabeza = anterior; // Actualizar la cabeza al nuevo inicio de la lista
        }

        // Método para mostrar la lista de pasajeros
        public void MostrarLista()
        {
            Nodo actual = Cabeza;

            if (actual == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            while (actual != null)
            {
                Console.WriteLine(actual.Nombre);
                actual = actual.Siguiente;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear una lista de pasajeros
            ListaPasajeros lista = new ListaPasajeros();

            // Agregar pasajeros a la lista
            lista.AgregarPasajero("Ana");
            lista.AgregarPasajero("Luis");
            lista.AgregarPasajero("Carlos");
            lista.AgregarPasajero("María");
            lista.AgregarPasajero("Juan");

            // Mostrar el orden original de los pasajeros
            Console.WriteLine("Orden original de la fila:");
            lista.MostrarLista();

            // Invertir el orden de la fila
            lista.InvertirOrden();

            // Mostrar el orden invertido de los pasajeros
            Console.WriteLine("\nOrden invertido de la fila:");
            lista.MostrarLista();
        }
    }
}
