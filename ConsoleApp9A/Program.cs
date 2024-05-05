namespace ConsoleApp9A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Calculo de distancia entre 2 puntos");

                Console.Write("Ingrese la coord. X del punto 1:");
                var coordX1 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese la coord. Y del punto 1:");
                var coordY1 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese la coord. X del punto 2:");
                var coordX2 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese la coord. Y del punto 2:");
                var coordY2 = int.Parse(Console.ReadLine());
                if (EstanEnMismaRecta(coordX1, coordY1, coordX2, coordY2))
                {
                    Console.WriteLine("Los puntos están en rectas perpendiculares");
                }

                var distancia = CalcularDistancia(coordX1, coordY1, coordX2, coordY2);
                Console.WriteLine($"La distancia entre ({coordX1},{coordY1}) y ({coordX2},{coordY2}) es {distancia:N2}");

            }
            catch (Exception)
            {

                Console.WriteLine("Alguno de los datos fueron mal ingresados!!!"); ;
            }
        }
        /// <summary>
        /// Método para calcular la distancia entre dos puntos del plano
        /// </summary>
        /// <param name="coordX1">Coordenada X del Primer Punto</param>
        /// <param name="coordY1">Coordenada Y del Primer Punto</param>
        /// <param name="coordX2">Coordenada X del Segundo Punto</param>
        /// <param name="coordY2">Coordenada Y del Segundo Punto</param>
        /// <returns>La distancia entre los puntos</returns>
        private static double CalcularDistancia(int coordX1,
            int coordY1, int coordX2, int coordY2)
        {
            return Math.Sqrt(Math.Pow(coordX2 - coordX1, 2)
                + Math.Pow(coordY2 - coordY1, 2));
        }
        /// <summary>
        /// Método para ver si dos puntos estan en una recta perpendicular
        /// </summary>
        /// <param name="coordX1">Coordenada X del Primer Punto</param>
        /// <param name="coordY1">Coordenada Y del Primer Punto</param>
        /// <param name="coordX2">Coordenada X del Segundo Punto</param>
        /// <param name="coordY2">Coordenada Y del Segundo Punto</param>
        /// <returns>bool</returns>
        private static bool EstanEnMismaRecta(int coordX1,
            int coordY1, int coordX2, int coordY2)
        {
            //if (coordY1==coordY2 || coordX1==coordX2)
            //{
            //    return true;
            //}
            //return false;
            return coordY1 == coordY2 || coordX1 == coordX2;
        }
    }
}
