using programa3.Class;
using System;

class Program
{
    static void Main()
    {
        double[] numeros = new double[4];

        try
        {
            
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Ingrese el número {i + 1}:");
                numeros[i] = Convert.ToDouble(Console.ReadLine());
            }

            
            double suma = Calculadora.CalcularSuma(numeros);

            
            double promedio = Calculadora.CalcularPromedio(suma);

          
            Console.WriteLine($"La suma de los cuatro números es: {suma}");
            Console.WriteLine($"El promedio de los cuatro números es: {promedio}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Por favor ingrese un número válido.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: El número ingresado es demasiado grande.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}