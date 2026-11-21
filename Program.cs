
using System;

class Program
{
    // Funcion que calcula el area del cuadrado
    static double AreaCuadrado(double lado)
    {
        return lado * lado;
    }

    // Funcion que calcula el area del circulo
    static double CalcularAreaCirculo(double radio)
    {
        double area = Math.PI * radio * radio;
        return area;
    }

    // Funcion que verifica si una persona es mayor o menor de edad
    static string VerificarEdad(int edad)
    {
        if (edad >= 18)
        {
            return "Es mayor de edad.";
        }
        else
        {
            return "Es menor de edad.";
        }
    }

    // Funcion que calcula el area del triangulo
    static double CalcularAreaTriangulo(double baseTriangulo, double altura)
    {
        double area = (baseTriangulo * altura) / 2;
        return area;
    }

    static void Main(string[] args)
    {
        int opcion;

        do
        {
            Console.Clear();

            Console.WriteLine("==================================");
            Console.WriteLine("       ACTIVIDAD 2 - METODOS");
            Console.WriteLine("==================================");
            Console.WriteLine("1. Calcular area del cuadrado");
            Console.WriteLine("2. Calcular area del circulo");
            Console.WriteLine("3. Verificar mayoria de edad");
            Console.WriteLine("4. Calcular area del triangulo");
            Console.WriteLine("5. Salir");
            Console.WriteLine("==================================");
            Console.Write("Seleccione una opcion: ");

            opcion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el lado del cuadrado: ");
                    double lado = Convert.ToDouble(Console.ReadLine());

                    double areaCuadrado = AreaCuadrado(lado);

                    Console.WriteLine("El area del cuadrado es: " + areaCuadrado);
                    break;

                case 2:
                    Console.Write("Ingrese el radio del circulo: ");
                    double radio = Convert.ToDouble(Console.ReadLine());

                    double areaCirculo = CalcularAreaCirculo(radio);

                    Console.WriteLine("El area del circulo es: " + areaCirculo);
                    break;

                case 3:
                    Console.Write("Ingrese su edad: ");
                    int edad = Convert.ToInt32(Console.ReadLine());

                    string mensaje = VerificarEdad(edad);

                    Console.WriteLine(mensaje);
                    break;

                case 4:
                    Console.Write("Ingrese la base del triangulo: ");
                    double baseTriangulo = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Ingrese la altura del triangulo: ");
                    double altura = Convert.ToDouble(Console.ReadLine());

                    double areaTriangulo = CalcularAreaTriangulo(baseTriangulo, altura);

                    Console.WriteLine("El area del triangulo es: " + areaTriangulo);
                    break;

                case 5:
                    Console.WriteLine("Gracias por utilizar el programa.");
                    break;

                default:
                    Console.WriteLine("Opcion no valida. Intente nuevamente.");
                    break;
            }

            if (opcion != 5)
            {
                Console.WriteLine();
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 5);
    }
}
