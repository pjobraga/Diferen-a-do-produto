using System;

namespace produto
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, prod;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            prod = A * B - (D * C);
            Console.WriteLine("Diferenca = "prod);

        }
    }
}