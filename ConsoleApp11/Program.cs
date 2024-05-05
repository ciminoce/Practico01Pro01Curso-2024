namespace ConsoleApp11
{
    internal class Program
    {
        static double ConvertirACelsius(double temperatura)
        {
            return temperatura;
        }

        static double ConvertirAReaumur(double temperatura)
        {
            return 0.8 * temperatura;
        }

        static double ConvertirAFahrenheit(double temperatura)
        {
            return 1.8 * temperatura + 32;
        }

        static double ConvertirAKelvin(double temperatura)
        {
            return temperatura + 273.15;
        }

        static double ConvertirARankine(double temperatura)
        {
            return 1.8 * temperatura + 491.67;
        }

        static void Main(string[] args)
        {
            Console.Write("Ingrese la temperatura en grados Celsius:");
            double celsius;
            if (!double.TryParse(Console.ReadLine(), out celsius))
            {
                Console.WriteLine("Por favor, ingrese un valor válido para la temperatura en grados Celsius.");
                return;
            }

            double reaumur = ConvertirAReaumur(celsius);
            double fahrenheit = ConvertirAFahrenheit(celsius);
            double kelvin = ConvertirAKelvin(celsius);
            double rankine = ConvertirARankine(celsius);

            Console.WriteLine($"Temperatura en grados Reaumur: {reaumur}");
            Console.WriteLine($"Temperatura en grados Fahrenheit: {fahrenheit}");
            Console.WriteLine($"Temperatura en grados Kelvin: {kelvin}");
            Console.WriteLine($"Temperatura en grados Rankine: {rankine}");
        }
    }
}
