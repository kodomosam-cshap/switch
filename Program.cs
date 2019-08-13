using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha um tipo de transporte");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "carro":
                    break;
                case "onibus":
                    break;
                case "trem":
                    break;
                default:
                    escolha = " indefinida";
                break;                    

            }

            Console.WriteLine($"A sua escolha foi {escolha}");
        }
    }
}
