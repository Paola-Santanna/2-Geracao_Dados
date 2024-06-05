﻿using Models;
using System.Text.Json;

namespace Repositories
{
    public class CarroRepository
    {
        private Carro carro { get; set; }
        public CarroRepository() { }

        public static void ConverterJson()
        {
            List<Carro> carros = GerarCarros();

            try
            {
                JsonSerializerOptions options = new JsonSerializerOptions();
                string jsonString = JsonSerializer.Serialize(carros, options);
                //salvar o arquivo .json em um local especifico
                File.WriteAllText("dados_carros.json", jsonString);

                Console.WriteLine("\nArquivo gerado com sucesso!");
                Console.WriteLine($"Foi salvo na seguinte pasta desta solução: \\Geracao_Dados\\Geracao_Dados\\bin\\Debug\\net6.0");
            }
            catch (Exception)
            {
                Console.WriteLine("\nFalha ao gerar o arquivo!\n");
            }
        }

        public static List<Carro> GerarCarros()
        {
            Carro carro;
            List<Carro> carros = new();

            for (int i = 0; i < 30; i++)
            {
                carro = new Carro();
                carros.Add(carro);
            }
            return carros;
        }
    }
}