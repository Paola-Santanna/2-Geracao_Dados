using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geracao_Dados
{
    public class Menu
    {
        public Menu() { }

        public int EscolherOpcao()
        {
            Console.WriteLine(">>>Menu<<<".ToUpper());
            Console.WriteLine("1 - Mostrar os carros gerados: ");
            Console.WriteLine("2 - Criar Arquivo .json dos carros gerados:");
            Console.WriteLine("\n0 - SAIR\n");
            Console.Write("Sua resposta: ");
            int opcao = int.Parse(Console.ReadLine());
            Console.Clear();
            return opcao;
        }

        public void MostrarOpcao(int opcao)
        {
            Carro carro;

            do
            {
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Sair");
                        break;

                    case 1:
                        Console.WriteLine("Carros Gerados: \n".ToUpper());
                        List<Carro> list = CarroRepository.GerarCarros();

                        foreach (var c in list)
                        {
                            Console.WriteLine(c.ToString());
                            Console.WriteLine();
                        }

                        opcao = Continuar();
                        break;

                    case 2:
                        Console.WriteLine("Criação do Arquivo: 'dados_carros.json' \n");
                        carro = new Carro();
                        CarroRepository.ConverterJson();
                        opcao = Continuar();
                        break;

                    default:
                        Console.WriteLine("\n\nOpcao Invalida!\n\n");
                        opcao = Continuar();
                        break;
                }
            } while (opcao != 0);
        }

        private int Continuar()
        {
            Console.WriteLine("\nPressione ENTER para continuar...");
            Console.ReadKey();
            Console.Clear();

            return EscolherOpcao();
        }
    }
}
