using System;

namespace HelloWorld
{
    class Program 
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine($"Seu nome tem {nome.Length} caracteres");

            Console.WriteLine("Digite a data do seu nascimento:");
            DateTime dtNascimento = DateTime.Parse(Console.ReadLine());

            int qtsDiasVividos = DateTime.Now.Subtract(dtNascimento).Days;
            Console.WriteLine("Os dias vividos até hoje são: " + qtsDiasVividos);

            Console.ReadKey();
            ;
        }
    }
}


