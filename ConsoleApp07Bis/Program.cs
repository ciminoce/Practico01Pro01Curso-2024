// Tasas de cambio respecto al peso argentino
const double TASA_EURO = 923.46;
const double TASA_DOLAR = 845.50;
const double TASA_YUAN = 118.19;

Console.Write("Ingrese la cantidad de dinero en pesos argentinos: ");
double pesos = double.Parse(Console.ReadLine());

Console.WriteLine("Elija la moneda a la que desea convertir:");
Console.WriteLine("a. Euro");
Console.WriteLine("b. Dólar estadounidense");
Console.WriteLine("c. Yuan chino");
Console.Write("Seleccione una opción: ");
char opcion = char.ToLower(Console.ReadKey().KeyChar);
Console.WriteLine();

// Convertir a la moneda seleccionada
double equivalente = 0;
switch (opcion)
{
    case 'a':
        equivalente = pesos / TASA_EURO;
        Console.WriteLine($"{pesos} ARS equivalen en euros: {equivalente:N2} EUR");
        break;
    case 'b':
        equivalente = pesos / TASA_DOLAR;
        Console.WriteLine($"{pesos} ARS equivalen en dólares: {equivalente:N2} USD");
        break;
    case 'c':
        equivalente = pesos / TASA_YUAN;
        Console.WriteLine($"{pesos} ARS equivalen en yuanes chinos: {equivalente:N2} CNY");
        break;
    default:
        Console.WriteLine("Opción no válida.");
        break;
}
    