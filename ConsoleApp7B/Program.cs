namespace ConsoleApp7B
{
    internal class Program
    {
        static int CalcularConversionMoneda(int montoEnPesosArgentinos, double valorCotizacionMoneda)
        {
            return (int)Math.Truncate(montoEnPesosArgentinos / valorCotizacionMoneda);
        }

        static void Main(string[] args)
        {
            const double TASA_DOLAR = 845.50;
            const double TASA_EURO = 923.46;
            const double TASA_YUAN = 118.19;
            int valorPesos;
            double montoConversion;
            char seleccionMoneda;

            Console.Write("Ingrese la cantidad de pesos a invertir:");
            int.TryParse(Console.ReadLine(), out valorPesos);

            if (valorPesos > 0)
            {
                Console.WriteLine("Monedas disponibles para invertir");
                Console.WriteLine("(D)ólar");
                Console.WriteLine("(E)uro");
                Console.WriteLine("(Y)uan");
                Console.Write("Ingrese su selección:");
                char.TryParse(Console.ReadLine(), out seleccionMoneda);

                if (char.ToUpper(seleccionMoneda) == 'D' || char.ToUpper(seleccionMoneda) == 'E' || char.ToUpper(seleccionMoneda) == 'Y')
                {
                    if (char.ToUpper(seleccionMoneda) == 'D')
                    {
                        montoConversion = CalcularConversionMoneda(valorPesos, TASA_DOLAR);
                        Console.WriteLine($"Con {valorPesos} ARS obtiene {montoConversion} USD");
                    }
                    else if (char.ToUpper(seleccionMoneda) == 'E')
                    {
                        montoConversion = CalcularConversionMoneda(valorPesos, TASA_EURO);
                        Console.WriteLine($"Con {valorPesos} ARS obtiene {montoConversion} EUR");
                    }
                    else
                    {
                        montoConversion = CalcularConversionMoneda(valorPesos, TASA_YUAN);
                        Console.WriteLine($"Con {valorPesos} ARS obtiene {montoConversion} CNY");
                    }
                }
                else
                {
                    Console.WriteLine("Selección de moneda errónea");
                }
            }
            else
            {
                Console.WriteLine("Monto en pesos argentinos (ARS) no válido");
            }
        }
    }
}
