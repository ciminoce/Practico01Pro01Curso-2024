namespace ConsoleApp7A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double TASA_DOLAR = 845.50;
            const double TASA_EURO = 923.46;
            const double TASA_YUAN = 118.19;
            int valorPesos;

            double montoDolar, montoEuro, montoYuan;

            Console.Write("Ingrese la cantidad de pesos a invertir:");
            int.TryParse(Console.ReadLine(), out valorPesos);

            if (valorPesos > 0)
            {
                montoDolar = (double)valorPesos / TASA_DOLAR;
                montoEuro = (double)valorPesos / TASA_EURO;
                montoYuan = (double)valorPesos / TASA_YUAN;

                Console.WriteLine($"Con {valorPesos} ARS obtendría:");
                Console.WriteLine($"{Math.Truncate(montoDolar)} USD");
                Console.WriteLine($"{Math.Truncate(montoEuro)} EUR");
                Console.WriteLine($"{Math.Truncate(montoYuan)} CNY");
            }
            else
            {
                Console.WriteLine("Monto en pesos argentinos (ARS) no válido");
            }
        }
    }
}
