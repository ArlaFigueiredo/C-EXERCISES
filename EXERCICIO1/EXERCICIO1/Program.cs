using System;
using System.Globalization;

namespace EXERCICIO1
{
    class MainClass
    {
        static void Main()
        {
            Pessoa p1, p2;
            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Informe o nome da pessoa: ");
            p1.nome = Console.ReadLine();
            Console.WriteLine("Informe a idade da pessoa: ");
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o nome da pessoa: ");
            p2.nome = Console.ReadLine();
            Console.WriteLine("Informe a idade da pessoa: ");
            p2.idade = int.Parse(Console.ReadLine());

            if (p1.idade > p2.idade)
                Console.WriteLine("O mais velho eh: "+ p1.nome);
            else
                Console.WriteLine("O mais velho eh: " + p2.nome);

        }
    }
}
