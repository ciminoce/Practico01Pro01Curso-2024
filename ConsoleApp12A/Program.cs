namespace ConsoleApp12A
{
    internal class Program
    {
        static double ConvertirAGramos(double cantidad, string unidad)
        {
            switch (unidad.ToLower())
            {
                case "g":
                    return cantidad;
                case "kg":
                    return cantidad * 1000;
                case "oz":
                    return cantidad * 28.3495;
                default:
                    return 0;
            }
        }

        static double ConvertirAKilogramos(double cantidad, string unidad)
        {
            switch (unidad.ToLower())
            {
                case "g":
                    return cantidad / 1000;
                case "kg":
                    return cantidad;
                case "oz":
                    return cantidad * 0.0283495;
                default:
                    return 0;
            }
        }

        static double ConvertirAOnzas(double cantidad, string unidad)
        {
            switch (unidad.ToLower())
            {
                case "g":
                    return cantidad * 0.035274;
                case "kg":
                    return cantidad * 35.274;
                case "oz":
                    return cantidad;
                default:
                    return 0;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione la unidad de peso inicial:");
            Console.WriteLine("1. Gramos (g)");
            Console.WriteLine("2. Kilogramos (kg)");
            Console.WriteLine("3. Onzas (oz)");
            Console.Write("Ingrese el número correspondiente a la unidad de peso inicial: ");
            int opcionInicial;
            if (!int.TryParse(Console.ReadLine(), out opcionInicial) || opcionInicial < 1 || opcionInicial > 3)
            {
                Console.WriteLine("Opción inválida.");
                return;
            }

            double cantidad;
            Console.Write("Ingrese la cantidad de peso:");
            if (!double.TryParse(Console.ReadLine(), out cantidad) || cantidad <= 0)
            {
                Console.WriteLine("Por favor, ingrese una cantidad de peso válida.");
                return;
            }

            double gramos = 0, kilogramos = 0, onzas = 0;

            switch (opcionInicial)
            {
                case 1:
                    gramos = cantidad;
                    kilogramos = ConvertirAKilogramos(cantidad, "g");
                    onzas = ConvertirAOnzas(cantidad, "g");
                    break;
                case 2:
                    kilogramos = cantidad;
                    gramos = ConvertirAGramos(cantidad, "kg");
                    onzas = ConvertirAOnzas(cantidad, "kg");
                    break;
                case 3:
                    onzas = cantidad;
                    gramos = ConvertirAGramos(cantidad, "oz");
                    kilogramos = ConvertirAKilogramos(cantidad, "oz");
                    break;
                default:
                    break;
            }

            Console.WriteLine($"Resultados para {cantidad}:");

            // Menú para convertir a otras unidades
            Console.WriteLine($"Seleccione la unidad a la que desea convertir {cantidad}:");
            Console.WriteLine("1. Gramos (g)");
            Console.WriteLine("2. Kilogramos (kg)");
            Console.WriteLine("3. Onzas (oz)");
            Console.Write("Ingrese el número correspondiente a la unidad de peso deseada: ");
            int opcionDestino;
            if (!int.TryParse(Console.ReadLine(), out opcionDestino) || opcionDestino < 1 || opcionDestino > 3)
            {
                Console.WriteLine("Opción inválida.");
                return;
            }

            switch (opcionDestino)
            {
                case 1:
                    Console.WriteLine($"Gramos (g): {gramos:N2}");
                    break;
                case 2:
                    Console.WriteLine($"Kilogramos (kg): {kilogramos:N2}");
                    break;
                case 3:
                    Console.WriteLine($"Onzas (oz): {onzas:N2}");
                    break;
                default:
                    break;
            }
        }
    }
}
