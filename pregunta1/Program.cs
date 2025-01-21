using System;

namespace CalcularLongitudLista
{
    // Clase que representa un nodo genérico de la lista
    public class Nodo<T>
    {
        public T Valor;          // Valor del nodo
        public Nodo<T> Siguiente; // Puntero al siguiente nodo

        // Constructor del nodo que asigna un valor
        public Nodo(T valor)
        {
            Valor = valor;
            Siguiente = null; // Inicialmente, no apunta a ningún nodo
        }
    }

    // Clase que representa una lista enlazada genérica
    public class ListaEnlazada<T>
    {
        private Nodo<T> Cabeza; // Nodo inicial de la lista
        private int Conteo;     // Atributo para llevar el conteo de nodos

        // Constructor que inicializa la lista vacía
        public ListaEnlazada()
        {
            Cabeza = null; // Al comienzo, la lista no tiene elementos
            Conteo = 0;    // La lista está vacía
        }

        // Método para agregar un nodo al final de la lista
        public void Agregar(T valor)
        {
            Nodo<T> nuevoNodo = new Nodo<T>(valor);

            if (Cabeza == null)
            {
                // Si la lista está vacía, el nuevo nodo será la cabeza
                Cabeza = nuevoNodo;
            }
            else
            {
                // Recorre hasta encontrar el último nodo
                Nodo<T> actual = Cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                // Agrega el nuevo nodo al final
                actual.Siguiente = nuevoNodo;
            }
            Conteo++; // Incrementa el conteo de nodos
        }

        // Función para calcular la longitud de la lista
        public int CalcularLongitud()
        {
            return Conteo; // Devuelve el conteo almacenado
        }

        // Método para imprimir los elementos de la lista
        public void Imprimir()
        {
            Nodo<T> actual = Cabeza;

            while (actual != null) // Recorre mientras haya nodos
            {
                Console.Write(actual.Valor + " "); // Imprime el valor del nodo
                actual = actual.Siguiente; // Pasa al siguiente nodo
            }
            Console.WriteLine(); // Salto de línea después de imprimir todos los valores
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear una lista enlazada
            ListaEnlazada<int> lista = new ListaEnlazada<int>();

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
