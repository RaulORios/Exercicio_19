using System;

namespace Exercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("*********     Exercicio 19     *********");
            Console.WriteLine("****************************************");

            Console.WriteLine("");

            int numero1;
            int numero2;
            
            Console.Write("Digite o primeiro número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            if (numero1 == numero2)
            {
                Console.WriteLine("Os números digitados são iguais.");
            }
            else if (numero1 > numero2)
            {
                Console.WriteLine($"O número {numero1} é maior que o número {numero2}");
            }
            else
            {
                Console.WriteLine($"O número {numero2} é maior que o número {numero1}");
            }
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
