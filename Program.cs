using System;

namespace cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma frase para Falar Igual o Cebolinha: ");
            string Frase = Console.ReadLine();
            Console.WriteLine(Frase.Replace("r" , "l"));

        }
    }
}
