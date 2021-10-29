using System;

namespace Maior2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;

            Console.Clear();
            Console.Beep();
            Console.Write("Digite o primeiro número : ");
            n1 = double.Parse(Console.ReadLine());
            
            Console.Write("Digite o segundo número : ");
            n2 = double.Parse(Console.ReadLine());

            if(n1 > n2)
            {
                Console.WriteLine($"\nO maior número é : {n1}");
            }
            else if(n2 > n1)
            {
                Console.WriteLine($"\nO maior número é : {n2}");
            }
            else if(n2 == n1)
            {
                Console.WriteLine($"\nNúmeros iguais");
            }

        }
    }
}
