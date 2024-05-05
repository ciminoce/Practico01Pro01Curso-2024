Console.Write("Ingrese las coordenadas del primer punto (x1 y y1):");
double x1 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());

Console.Write("Ingrese las coordenadas del segundo punto (x2 y y2):");
double x2 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());

// Verificar si los puntos están en línea recta
if (x1 == x2 || y1 == y2)
{
    Console.WriteLine("Los puntos están en línea recta.");
}
else
{
    Console.WriteLine("Los puntos no están en línea recta.");
}

Console.WriteLine("¿Qué tipo de distancia desea calcular?");
Console.WriteLine("1. Distancia en línea recta (euclidiana)");
Console.WriteLine("2. Distancia horizontal");
Console.WriteLine("3. Distancia vertical");
Console.Write("Seleccione una opción: ");
int opcion = int.Parse(Console.ReadLine());

double distancia = 0;

switch (opcion)
{
    case 1:
        distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        Console.WriteLine($"La distancia en línea recta entre los puntos es: {distancia:N2}");
        break;
    case 2:
        distancia = Math.Abs(x2 - x1);
        Console.WriteLine($"La distancia horizontal entre los puntos es: {distancia:N2}");
        break;
    case 3:
        distancia = Math.Abs(y2 - y1);
        Console.WriteLine($"La distancia vertical entre los puntos es: {distancia:N2}");
        break;
    default:
        Console.WriteLine("Opción no válida.");
        return;
}