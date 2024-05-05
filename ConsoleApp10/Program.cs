namespace ConsoleApp10
{
    internal class Program
    {
        static double CalcularPerimetro(double ladoMayor, double ladoMenor)
        {
            return 2 * ladoMayor + 2 * ladoMenor;
        }

        static double CalcularSuperficie(double ladoMayor, double ladoMenor)
        {
            return ladoMayor * ladoMenor;
        }

        static double CalcularDiagonal(double ladoMayor, double ladoMenor)
        {
            return Math.Sqrt(Math.Pow(ladoMayor, 2) + Math.Pow(ladoMenor, 2));
        }

        static void Main(string[] args)
        {
            Console.Write("Ingrese la longitud del lado mayor del rectángulo:");
            double ladoMayor;
            if (!double.TryParse(Console.ReadLine(), out ladoMayor) || ladoMayor <= 0)
            {
                Console.WriteLine("Por favor, ingrese un valor válido para la longitud del lado mayor.");
                return;
            }

            Console.Write("Ingrese la longitud del lado menor del rectángulo:");
            double ladoMenor;
            if (!double.TryParse(Console.ReadLine(), out ladoMenor) || ladoMenor <= 0)
            {
                Console.WriteLine("Por favor, ingrese un valor válido para la longitud del lado menor.");
                return;
            }

            double perimetro = CalcularPerimetro(ladoMayor, ladoMenor);
            double superficie = CalcularSuperficie(ladoMayor, ladoMenor);
            double diagonal = CalcularDiagonal(ladoMayor, ladoMenor);

            Console.WriteLine($"El perímetro del rectángulo es: {perimetro}");
            Console.WriteLine($"La superficie del rectángulo es: {superficie}");
            Console.WriteLine($"La diagonal del rectángulo es: {diagonal}");
        }
    }
}
