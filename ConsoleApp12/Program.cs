namespace ConsoleApp12
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de peso:");
            double peso;
            if (!double.TryParse(Console.ReadLine(), out peso) || peso <= 0)
            {
                Console.WriteLine("Por favor, ingrese una cantidad de peso válida.");
                return;
            }

            Console.WriteLine("Seleccione la unidad de peso:");
            Console.WriteLine("1. Gramos (g)");
            Console.WriteLine("2. Kilogramos (kg)");
            Console.WriteLine("3. Onzas (oz)");
            Console.Write("Ingrese el número correspondiente a la unidad de peso: ");
            int opcion;
            if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 3)
            {
                Console.WriteLine("Opción inválida.");
                return;
            }

            double gramos = 0, kilogramos = 0, onzas = 0;

            switch (opcion)
            {
                case 1:
                    gramos = peso;
                    kilogramos = peso / 1000;
                    onzas = peso * 0.035274;
                    break;
                case 2:
                    kilogramos = peso;
                    gramos = peso * 1000;
                    onzas = peso * 35.274;
                    break;
                case 3:
                    onzas = peso;
                    gramos = peso / 0.035274;
                    kilogramos = peso / 35.274;
                    break;
                default:
                    break;
            }

            Console.WriteLine($"Resultados:");
            Console.WriteLine($"Gramos (g): {gramos:N2}");
            Console.WriteLine($"Kilogramos (kg): {kilogramos:N2}");
            Console.WriteLine($"Onzas (oz): {onzas:N2}");
        }
    }
}
