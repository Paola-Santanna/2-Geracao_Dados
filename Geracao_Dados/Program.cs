using System.Security.Cryptography.X509Certificates;

namespace Geracao_Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            Console.WriteLine("Gerador de dados sobre carros".ToUpper());
            int opcao = menu.EscolherOpcao();
            menu.MostrarOpcao(opcao);

            Console.Clear();
            Console.WriteLine("\nFim do Programa");
        }
    }
}