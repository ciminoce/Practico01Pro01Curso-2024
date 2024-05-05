namespace ConsoleApp05
{
    internal class Program
    {
        static double CalcularPerimetro(double radio)
        {
            return 2 * Math.PI * radio;
        }

        static double CalcularSuperficie(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        static double CalcularDiametro(double radio)
        {
            return 2 * radio;
        }

        static double CalcularLongitudArco(double radio)
        {
            return Math.PI * CalcularDiametro(radio);
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ingrese el radio de la circunferencia:");
                double radio = double.Parse(Console.ReadLine());

                double perimetro = CalcularPerimetro(radio);
                double superficie = CalcularSuperficie(radio);
                double diametro = CalcularDiametro(radio);
                double longitudArco = CalcularLongitudArco(radio);

                Console.WriteLine($"Perímetro de la circunferencia: {perimetro}");
                Console.WriteLine($"Superficie de la circunferencia: {superficie}");
                Console.WriteLine($"Diámetro de la circunferencia: {diametro}");
                Console.WriteLine($"Longitud del arco de la circunferencia: {longitudArco}");

            }
            catch (FormatException)
            {

                Console.WriteLine("Radio mal ingresado..."); ;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Radio demasiado grande para un nro. entero");
            }
            catch (Exception)
            {
                Console.WriteLine("Error inesperado...");
            }
        }
    }
}
