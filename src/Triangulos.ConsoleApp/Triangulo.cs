namespace Triangulos.ConsoleApp
{
    public class Triangulo
    {
        public int LadoX;
        public int LadoY;
        public int LadoZ;

        public string ObterTipo()
        {
            string tipo = "";

            if (LadoXInvalido() || LadoYInvalido() || LadoZInvalido())
                tipo = "Triângulo Inválido";

            else if (LadoX == LadoY && LadoY == LadoZ)
                tipo = "Equilátero";

            else if (LadoX != LadoY && LadoY != LadoZ && LadoZ != LadoX)
                tipo = "Escaleno";

            else
                tipo = "Isósceles";

            return tipo;
        }

        public bool LadoXInvalido()
        {
            bool ladoXInvalido = LadoX > LadoY + LadoZ;

            return ladoXInvalido;
        }

        public bool LadoYInvalido()
        {
            bool ladoYInvalido = LadoY > LadoX + LadoZ;

            return ladoYInvalido;
        }

        public bool LadoZInvalido()
        {
            bool ladoZInvalido = LadoZ > LadoX + LadoY;

            return ladoZInvalido;
        }
    }
}
