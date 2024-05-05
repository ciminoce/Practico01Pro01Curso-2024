Console.WriteLine("Ingrese las coordenadas del primer punto (x1 y y1):");
double x1 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese las coordenadas del segundo punto (x2 y y2):");
double x2 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());

// Calcular la distancia utilizando la fórmula proporcionada
double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

Console.WriteLine($"La distancia entre los puntos ({x1}, {y1}) y ({x2}, {y2}) es: {distancia:N2}");