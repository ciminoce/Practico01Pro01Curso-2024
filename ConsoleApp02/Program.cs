namespace ConsoleApp02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer número:");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número:");
            double num2 = double.Parse(Console.ReadLine());

            // Suma
            double suma = num1 + num2;
            Console.WriteLine($"Suma: {suma}");

            // Resta
            double resta = num1 - num2;
            Console.WriteLine($"Resta: {resta}");

            // Multiplicación
            double multiplicacion = num1 * num2;
            Console.WriteLine($"Multiplicación: {multiplicacion}");

            // División (Evitar división por cero)
            if (num2 != 0)
            {
                double division = num1 / num2;
                Console.WriteLine($"División: {division}");
            }
            else
            {
                Console.WriteLine("No es posible dividir por cero.");
            }
        }
    }
}
