using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro numero que deseja fazer a operação: ");
            int N1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero que deseja fazer a operação: ");
            int N2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite qual operação deseja 1(+), 2(-), 3(/), 4(*): ");
            int conta = int.Parse(Console.ReadLine());

            switch (conta)
            {
                case 1:
                    int soma = N1 + N2;
                    Console.WriteLine("O resultado da sua soma desejada é de: " + soma);
                break;
                case 2:
                    int menos = N1 - N2;
                    Console.WriteLine("O resultado da sua subtração desejada é de: " + menos);
                break;
                case 3:
                    int divi = N1 / N2;
                    Console.WriteLine("O resultado da sua divisão desejada é de: " + divi);
                break;
                case 4:
                    int multi = N1 * N2;
                    Console.WriteLine("O resultado da sua multiplicação desejada é de: " + multi);
                break;
            }

            Console.ReadKey();

        }
    }
}
