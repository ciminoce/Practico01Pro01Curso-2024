// Tasas de cambio respecto al peso argentino
const double TASA_EURO = 923.46;
const double TASA_DOLAR = 845.50;
const double TASA_YUAN = 118.19;

Console.Write("Ingrese la cantidad de dinero en pesos argentinos: ");
double pesos = double.Parse(Console.ReadLine());

if (pesos>0)
{
	// Convertir a euros, dólares y yuanes
	double euros = pesos / TASA_EURO;
	double dolares = pesos / TASA_DOLAR;
	double yuanes = pesos / TASA_YUAN;

	// Mostrar resultados
	Console.WriteLine($"{pesos} ARS equivalen en euros: {euros:N2} EUR");
	Console.WriteLine($"{pesos} ARS equivalen en dólares: {dolares:N2} USD");
	Console.WriteLine($"{pesos} ARS equivalen en yuanes chinos: {yuanes:N2} CNY");
}
else
{
    Console.WriteLine("Cantidad de pesos no válida!!!");
}