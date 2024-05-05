try
{
    //Definición de Variables
    double numero1;
    double numero2;
    double resultadoSuma;

    //Ingreso de datos
    // 1 o "1"
    Console.Write("Ingrese el primer valor a sumar:");
    numero1 = double.Parse(Console.ReadLine());//"12"
    Console.Write("Ingrese el segundo valor a sumar:");
    numero2 = double.Parse(Console.ReadLine());

    //Obtener resultado
    resultadoSuma = numero1 + numero2;

    //Mostrar la información obtenida
    Console.WriteLine($"La suma de {numero1} y {numero2} es {resultadoSuma}");

}
catch (Exception)
{

    Console.WriteLine("Algo se ingresó mal!!!"); ;
}