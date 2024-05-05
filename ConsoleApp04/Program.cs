using System.Text;

namespace ConsoleApp04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la longitud del lado del cuadrado:");
            double lado = double.Parse(Console.ReadLine());

            // Calcular perímetro
            double perimetro = lado * 4;

            // Calcular superficie
            double superficie = lado * lado;

            // Calcular longitud de la diagonal
            double diagonal = Math.Sqrt(2) * lado;
            //Uso de la clase StringBuilder==>debe importar el espacio de nombres System.Text
            StringBuilder sb=new StringBuilder();
            sb.AppendLine($"Perímetro del cuadrado: {perimetro}");
            sb.AppendLine($"Superficie del cuadrado: {superficie}");
            sb.AppendLine($"Longitud de la diagonal del cuadrado: {diagonal}");
            Console.WriteLine(sb.ToString());
        }
    }
}
