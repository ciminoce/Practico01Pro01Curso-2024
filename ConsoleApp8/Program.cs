namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor de N:");
            int n;
            if (!int.TryParse(Console.ReadLine(), out n) || n < 1)
            {
                Console.WriteLine("Por favor, ingrese un valor entero positivo para N.");
                return;
            }

            int suma = (n * (n + 1)) / 2;
            Console.WriteLine($"La suma de los primeros {n} números enteros es: {suma}");
        }
    }
}
