namespace ConsoleApp06B
{
    internal class Program
    {
        static bool ValidarNumeroIngresado(int numeroIngresado, int valorMenor, int valorMayor)
        {
            return numeroIngresado >= valorMenor && numeroIngresado <= valorMayor;
        }


        static double ConvertirKms(double valorEnKilometros, double valorConversion)
        {
            return valorEnKilometros * valorConversion;
        }

        static void Main(string[] args)
        {
            const double KILOMETRO_A_MILLAS = 0.621371192;
            const double KILOMETRO_A_YARDAS = 1093.6133;
            const double KILOMETRO_A_METROS = 1000;

            int kilometros;
            double distanciaConvertida;

            int opcionSeleccionada;

            Console.Write("Ingrese la cantidad de kilómetros a convertir:");
            int.TryParse(Console.ReadLine(), out kilometros);

            if (kilometros > 0)
            {
                Console.WriteLine("Selección de Conversión");
                Console.WriteLine("1-Metros");
                Console.WriteLine("2-Millas");
                Console.WriteLine("3-Yardas");
                Console.Write("Ingrese la opción seleccionada:");
                int.TryParse(Console.ReadLine(), out opcionSeleccionada);

                if (ValidarNumeroIngresado(opcionSeleccionada, 1, 3))
                {
                    switch (opcionSeleccionada)
                    {
                        case 1:
                            distanciaConvertida = ConvertirKms(kilometros, KILOMETRO_A_METROS);
                            Console.WriteLine($"	{distanciaConvertida:N2} mts");
                            break;
                        case 2:
                            distanciaConvertida = ConvertirKms(kilometros, KILOMETRO_A_MILLAS);
                            Console.WriteLine($"	{distanciaConvertida:N2} millas");
                            break;
                        case 3:
                            distanciaConvertida = ConvertirKms(kilometros, KILOMETRO_A_YARDAS);
                            Console.WriteLine($"	{distanciaConvertida:N2} yardas");
                            break;
                        default:
                            Console.WriteLine("Opción no válida");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Selección fuera del rango permitido");
                }
            }
            else
            {
                Console.WriteLine("Cantidad de kilómetros no válida");
            }
        }
    }
}
