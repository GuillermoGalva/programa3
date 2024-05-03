

namespace programa3.Class
{
    class Calculadora
    {
        public static double CalcularSuma(double[] numeros)
        {
            double suma = 0;

            foreach (double numero in numeros)
            {
                suma += numero;
            }

            return suma;
        }

        public static double CalcularPromedio(double suma)
        {
            return suma / 4;
        }
    }
}
