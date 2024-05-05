namespace ConsoleApp06
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

            double millas = kilometros * KILOMETRO_A_MILLAS;
            double yardas = kilometros * KILOMETRO_A_YARDAS;
            double metros = kilometros * KILOMETRO_A_METROS;

            Console.WriteLine($"Distancia en millas: {millas}");
            Console.WriteLine($"Distancia en yardas: {yardas}");
            Console.WriteLine($"Distancia en metros: {metros}");
        }
    }
}
