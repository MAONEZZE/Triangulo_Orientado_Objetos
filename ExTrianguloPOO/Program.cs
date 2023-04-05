namespace ExTrianguloPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ladoA, ladoB, ladoC;
            string nomeTriangulo;

            Console.Write("Digite o lado A do triangulo: ");
            ladoA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o lado B do triangulo: ");
            ladoB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o lado C do triangulo: ");
            ladoC = Convert.ToDouble(Console.ReadLine());

            Triangulo tri = new Triangulo(ladoA, ladoB, ladoC);

            nomeTriangulo = tri.verificaLado();

            Console.WriteLine(nomeTriangulo);

        }
    }
}