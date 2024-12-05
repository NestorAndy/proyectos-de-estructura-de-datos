using System;

namespace FigurasGeometricas
{
    // Clase que representa un círculo
    public class Circulo
    {
        private double radio;  // Atributo privado que almacena el radio del círculo

        // Constructor para inicializar el radio
        public Circulo(double radio)
        {
            this.radio = radio;
        }

        // Método para calcular el área del círculo
        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        // Método para calcular el perímetro del círculo
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }

    // Clase que representa un rectángulo
    public class Rectangulo
    {
        private double ancho;   // Atributo privado que almacena el ancho del rectángulo
        private double altura;  // Atributo privado que almacena la altura del rectángulo

        // Constructor para inicializar el ancho y la altura
        public Rectangulo(double ancho, double altura)
        {
            this.ancho = ancho;
            this.altura = altura;
        }

        // Método para calcular el área del rectángulo
        public double CalcularArea()
        {
            return ancho * altura;
        }

        // Método para calcular el perímetro del rectángulo
        public double CalcularPerimetro()
        {
            return 2 * (ancho + altura);
        }
    }

    // Clase principal para ejecutar el programa
    public class Program
    {
        public static void Main(string[] args)
        {
            // Crear un círculo con radio 5
            Circulo circulo = new Circulo(5.0);
            Console.WriteLine("Círculo:");
            Console.WriteLine("Área: " + circulo.CalcularArea());
            Console.WriteLine("Perímetro: " + circulo.CalcularPerimetro());

            // Crear un rectángulo con ancho 4 y altura 6
            Rectangulo rectangulo = new Rectangulo(4.0, 6.0);
            Console.WriteLine("\nRectángulo:");
            Console.WriteLine("Área: " + rectangulo.CalcularArea());
            Console.WriteLine("Perímetro: " + rectangulo.CalcularPerimetro());
        }
    }
}
