using System;

namespace CalcularLongitudLista
{
    // Clase que representa un nodo de la lista
    public class Nodo
    {
        public int Valor;       // Valor del nodo
        public Nodo Siguiente;  // Puntero al siguiente nodo

        public Nodo(int valor)
        {
            Valor = valor;
            Siguiente = null; // Inicialmente, no apunta a ningún nodo
        }
    }

    // Clase que representa la lista enlazada
    public class ListaEnlazada
    {
        public Nodo Cabeza; // Nodo inicial de la lista

        public ListaEnlazada()
        {
            Cabeza = null; // Inicialmente, la lista está vacía
        }

        // Método para agregar un nodo al final de la lista
        public void Agregar(int valor)
        {
            Nodo nuevoNodo = new Nodo(valor);

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

        // Función para calcular la longitud de la lista
        public int CalcularLongitud()
        {
            int longitud = 0;
            Nodo actual = Cabeza;

            while (actual != null) // Recorre mientras haya nodos
            {
                longitud++;          // Incrementa el contador
                actual = actual.Siguiente; // Pasa al siguiente nodo
            }

            return longitud; // Devuelve la longitud de la lista
        }

        // Método para imprimir los elementos de la lista
        public void Imprimir()
        {
            Nodo actual = Cabeza;

            while (actual != null)
            {
                Console.Write(actual.Valor + " ");
                actual = actual.Siguiente;
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear una lista enlazada
            ListaEnlazada lista = new ListaEnlazada();

            // Agregar elementos a la lista
            lista.Agregar(5);
            lista.Agregar(10);
            lista.Agregar(15);
            lista.Agregar(20);

            // Imprimir la lista
            Console.WriteLine("Elementos de la lista:");
            lista.Imprimir();

            // Calcular y mostrar la longitud de la lista
            Console.WriteLine("Longitud de la lista: " + lista.CalcularLongitud());
        }
    }
}

