namespace ConsoleApp06A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double KILOMETRO_A_MILLAS = 0.621371192;
            const double KILOMETRO_A_YARDAS = 1093.6133;
            const double KILOMETRO_A_METROS = 1000;

            Console.Write("Ingrese la distancia en kilómetros:");
            double kilometros;
            if (!double.TryParse(Console.ReadLine(), out kilometros) || kilometros <= 0)
            {
                Console.WriteLine("La distancia en kilómetros debe ser un número mayor que cero.");
                return;
            }

            Console.WriteLine("Seleccione la conversión:");
            Console.WriteLine("1. Kilómetros a millas");
            Console.WriteLine("2. Kilómetros a yardas");
            Console.WriteLine("3. Kilómetros a metros");
            Console.Write("Ingrese opción:");
            int opcion;
            if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 3)
            {
                Console.WriteLine("Opción no válida.");
                return;
            }

            switch (opcion)
            {
                case 1:
                    double millas = kilometros * KILOMETRO_A_MILLAS;
                    Console.WriteLine($"Distancia en millas: {millas}");
                    break;
                case 2:
                    double yardas = kilometros * KILOMETRO_A_YARDAS;
                    Console.WriteLine($"Distancia en yardas: {yardas}");
                    break;
                case 3:
                    double metros = kilometros * KILOMETRO_A_METROS;
                    Console.WriteLine($"Distancia en metros: {metros}");
                    break;
            }
        }
    }
}
