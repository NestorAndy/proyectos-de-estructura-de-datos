﻿using System;

namespace CalcularLongitudLista
{
    // Clase que representa un nodo de la lista
    public class Nodo
    {
        public int Valor;       // Valor del nodo
        public Nodo Siguiente;  // Puntero al siguiente nodo

        // Constructor del nodo que asigna un valor
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

        // Constructor que inicializa la lista vacía
        public ListaEnlazada()
        {
            Cabeza = null; // Al comienzo, la lista no tiene elementos
        }

        // Método para agregar un nodo al final de la lista
        public void Agregar(int valor)
        {
            Nodo nuevoNodo = new Nodo(valor);

            if (Cabeza == null)
            {
                // Si la lista está vacía, el nuevo nodo será la cabeza
                Cabeza = nuevoNodo;
            }
            else
            {
                // Recorre hasta encontrar el último nodo
                Nodo actual = Cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                // Agrega el nuevo nodo al final
                actual.Siguiente = nuevoNodo;
            }
        }

        // Función para calcular la longitud de la lista
        public int CalcularLongitud()
        {
            int longitud = 0;      // Contador para la longitud
            Nodo actual = Cabeza;  // Nodo auxiliar para recorrer la lista

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

