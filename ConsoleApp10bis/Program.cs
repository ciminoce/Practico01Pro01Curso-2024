Console.Write("Ingrese la temperatura seguida de la escala (por ejemplo, 25C para Celsius, 25R para Réaumur, 25F para Fahrenheit, 25K para Kelvin, 25N para Rankine): ");
string entrada = Console.ReadLine();

// Obtener la temperatura y la escala
double temperatura;
string escala;
if (!double.TryParse(entrada.Substring(0, entrada.Length - 1), out temperatura) || entrada.Length < 2)
{
    Console.WriteLine("Entrada no válida.");
    return;
}
escala = entrada.Substring(entrada.Length - 1, 1).ToUpper();

// Realizar las conversiones según la escala
double celsius, reaumur, fahrenheit, kelvin, rankine;
switch (escala)
{
    case "C":
        celsius = temperatura;
        reaumur = 0.8 * celsius;
        fahrenheit = (1.8 * celsius) + 32;
        kelvin = celsius + 273.15;
        rankine = (1.8 * celsius) + 491.67;
        Console.WriteLine($"Temperatura en grados Réaumur: {reaumur:N2}");
        Console.WriteLine($"Temperatura en grados Fahrenheit: {fahrenheit:N2}");
        Console.WriteLine($"Temperatura en Kelvin: {kelvin:N2}");
        Console.WriteLine($"Temperatura en Rankine: {rankine:N2}");
        break;
    case "R":
        reaumur = temperatura;
        celsius = reaumur / 0.8;
        fahrenheit = (1.8 * celsius) + 32;
        kelvin = celsius + 273.15;
        rankine = (1.8 * celsius) + 491.67;
        Console.WriteLine($"Temperatura en grados Celsius: {celsius:N2}");
        Console.WriteLine($"Temperatura en grados Fahrenheit: {fahrenheit:N2}");
        Console.WriteLine($"Temperatura en Kelvin: {kelvin:N2}");
        Console.WriteLine($"Temperatura en Rankine: {rankine:N2}");
        break;
    case "F":
        fahrenheit = temperatura;
        celsius = (fahrenheit - 32) / 1.8;
        reaumur = 0.8 * celsius;
        kelvin = celsius + 273.15;
        rankine = (1.8 * celsius) + 491.67;
        Console.WriteLine($"Temperatura en grados Celsius: {celsius:N2}");
        Console.WriteLine($"Temperatura en grados Réaumur: {reaumur:N2}");
        Console.WriteLine($"Temperatura en Kelvin: {kelvin:N2}");
        Console.WriteLine($"Temperatura en Rankine: {rankine:N2}");
        break;
    case "K":
        kelvin = temperatura;
        celsius = kelvin - 273.15;
        reaumur = 0.8 * celsius;
        fahrenheit = (1.8 * celsius) + 32;
        rankine = (1.8 * celsius) + 491.67;
        Console.WriteLine($"Temperatura en grados Celsius: {celsius:N2}");
        Console.WriteLine($"Temperatura en grados Réaumur: {reaumur:N2}");
        Console.WriteLine($"Temperatura en grados Fahrenheit: {fahrenheit:N2}");
        Console.WriteLine($"Temperatura en Rankine: {rankine:N2}");
        break;
    case "N":
        rankine = temperatura;
        celsius = (rankine - 491.67) / 1.8;
        reaumur = 0.8 * celsius;
        fahrenheit = (1.8 * celsius) + 32;
        kelvin = celsius + 273.15;
        Console.WriteLine($"Temperatura en grados Celsius: {celsius:N2}");
        Console.WriteLine($"Temperatura en grados Réaumur: {reaumur:N2}");
        Console.WriteLine($"Temperatura en grados Fahrenheit: {fahrenheit:N2}");
        Console.WriteLine($"Temperatura en Kelvin: {kelvin:N2}");
        break;
    default:
        Console.WriteLine("Escala de temperatura no válida.");
        break;
}