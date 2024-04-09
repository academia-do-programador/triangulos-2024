namespace Triangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo1 = new Triangulo();

            triangulo1.LadoX = 10;
            triangulo1.LadoY = 10;
            triangulo1.LadoZ = 10;

            Console.WriteLine(triangulo1.ObterTipo()); // Equilátero

            Triangulo triangulo2 = new Triangulo();

            triangulo2.LadoX = 12;
            triangulo2.LadoY = 10;
            triangulo2.LadoZ = 10;

            Console.WriteLine(triangulo2.ObterTipo()); // Isósceles

            Triangulo triangulo3 = new Triangulo();

            triangulo3.LadoX = 12;
            triangulo3.LadoY = 14;
            triangulo3.LadoZ = 16;

            Console.WriteLine(triangulo3.ObterTipo()); // Escaleno

            Console.ReadLine();
        }
    }
}
