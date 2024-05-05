const double VALOR_RADIANES = 0.0174532925;
Console.WriteLine("Seleccione el formato de ingreso:");
Console.WriteLine("1. Decimal (grados decimales)");
Console.WriteLine("2. Grados, minutos y segundos (grados sexagesimales)");
Console.Write("Ingrese su opción:");

try
{
    int opcionFormato = int.Parse(Console.ReadLine());

    double grados;
    double radianes;

    if (opcionFormato == 1)
    {
        Console.Write("Ingrese el valor en grados decimales: ");
        grados = double.Parse(Console.ReadLine());
        if (grados<=0 || grados >= 360)
        {
            Console.WriteLine("Los grados deben estar entre 0 y 360.");
            return;
        }

        radianes=ConvertirGradosRadianes(grados);
        Console.WriteLine($"El equivalente en radianes es {radianes:N2}");
    }
    else if (opcionFormato == 2)
    {
        Console.Write("Ingrese los grados: ");
        int gradosInput = int.Parse(Console.ReadLine());

        Console.Write("Ingrese los minutos: ");
        int minutosInput = int.Parse(Console.ReadLine());

        Console.Write("Ingrese los segundos: ");
        int segundosInput = int.Parse(Console.ReadLine());

        if (gradosInput <= 0 || gradosInput >= 360)
        {
            Console.WriteLine("Los grados deben estar entre 0 y 360.");
            return;
        }

        // Validar que los minutos estén en el rango de 0 a 59
        if (minutosInput < 0 || minutosInput >= 60)
        {
            Console.WriteLine("Los minutos deben estar entre 0 y 59.");
            return;
        }

        // Validar que los segundos estén en el rango de 0 a 59
        if (segundosInput < 0 || segundosInput >= 60)
        {
            Console.WriteLine("Los segundos deben estar entre 0 y 59.");
            return;
        }
        Console.WriteLine($"Se muestra en notación sexagesimal: {gradosInput}° {minutosInput}' {segundosInput:N2}");

        grados = gradosInput + (minutosInput / 60.0) + (segundosInput / 3600.0);
        radianes = ConvertirGradosRadianes(grados);
        Console.WriteLine($"El equivalente en radianes es {radianes:N2}");

    }
    else
    {
        Console.WriteLine("Opción no válida.");
        return;
    }


    // Mostrar el resultado
}
catch (Exception)
{

    Console.WriteLine("Algo anduvo mal!!!"); ;
}

double ConvertirGradosRadianes(double grados)
{
    return grados* VALOR_RADIANES;
}