namespace ConsoleApp11A
{
    internal class Program
    {
        static double ConvertirCelsiusRankine(double temperatura)
        {
            return (1.8 * temperatura) + 491.67;
        }

        static double ConvertirCelsiusKelvin(double temperatura)
        {
            return temperatura + 273.15;
        }

        static double ConvertirCelsiusReaumur(double temperatura)
        {
            return 0.8 * temperatura;
        }

        static double ConvertirCelsiusFahrenheit(double temperatura)
        {
            return 1.8 * temperatura + 32;
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

            Console.WriteLine("Opciones de Conversión:");
            Console.WriteLine("(F)ahrenheit");
            Console.WriteLine("(R)eaumur");
            Console.WriteLine("(K)elvin");
            Console.WriteLine("R(a)nkine");
            Console.Write("Ingrese una de las opciones: ");
            char letraIngresada = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            double conversion = 0;
            switch (letraIngresada)
            {
                case 'F':
                    conversion = ConvertirCelsiusFahrenheit(celsius);
                    break;
                case 'R':
                    conversion = ConvertirCelsiusReaumur(celsius);
                    break;
                case 'K':
                    conversion = ConvertirCelsiusKelvin(celsius);
                    break;
                case 'A':
                    conversion = ConvertirCelsiusRankine(celsius);
                    break;
                default:
                    Console.WriteLine("Opción ingresada no válida.");
                    return;
            }

            Console.WriteLine($"La temperatura convertida es: {conversion:N2}");
        }
    }
}
