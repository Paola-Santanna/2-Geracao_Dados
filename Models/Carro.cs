using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Models
{
    public class Carro
    {
        public string Placa { get; set; }
        public string Nome { get; set; }
        public int AnoModelo { get; set; }
        public int AnoFabricacao { get; set; }
        public string Cor { get; set; }
        public int Vendido { get; set; }
        public Carro()
        {
            PopularPropriedades();
        }

        private string GerarCor()
        {
            List<string> cores = new() { "Cinza", "Amarelo", "Preto", "Branco", "Vermelho" };
            int indice = new Random().Next(cores.Count);
            string corGerada = cores[indice];
            return corGerada;
        }

        private string GerarNome()
        {
            List<string> nomes = new() { "Prisma", "Fox", "Kombi Corujinha", "Jeep", "Compass", "Uno" };
            int indice = new Random().Next(nomes.Count);
            string nomeGerado = nomes[indice];
            return nomeGerado;
        }

        private int GerarAnoModelo()
        {
            int AnoGerado = new Random().Next(1990, 2024);
            return AnoGerado;
        }

        private int GerarAnoFabricacao()
        {

            int AnoGerado = new Random().Next(1990, 2024);
            return AnoGerado;
        }

        private string GerarPlaca()
        {
            string parte1 = $"{SortearLetra()}{SortearLetra()}{SortearLetra()}";
            string parte2 = $"{SortearNum()}{SortearLetra()}{SortearNum()}{SortearNum()}";
            string placaGerada = parte1 + parte2;
            return placaGerada;
        }

        private string SortearLetra()
        {
            List<string> letras = new() { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            int indice = new Random().Next(letras.Count);
            string letraSorteada = letras[indice];
            return letraSorteada;
        }

        private int SortearNum()
        {
            int num = new Random().Next(0, 9);
            return num;
        }

        private int StatusVendido()
        {
            int status = 0 ;
            bool vendido = false;
            
            do
            {
                status = new Random().Next(-1, 2);
            } while (status != 0 && status != 1);

            //if (status == 1)
            //    vendido = true;
            //else
            //    vendido = false;

            return status;
        }
        private void PopularPropriedades()
        {
            this.Placa = GerarPlaca();
            this.Nome = GerarNome();

            int anoModelo, anoFabricacao;
            bool b = false;
            do
            {
                anoModelo = GerarAnoModelo();
                anoFabricacao = GerarAnoFabricacao();

                if (anoFabricacao >= anoModelo)
                    b = true;
                else if (anoModelo == anoFabricacao + 1)
                    b = true;

            } while (b != true);

            this.AnoModelo = anoModelo;
            this.AnoFabricacao = anoFabricacao;
            this.Cor = GerarCor();
            this.Vendido = StatusVendido();
        }
        public override string? ToString()
        {
            return $"Placa: {this.Placa} \nNome: {this.Nome} \nAno do Modelo: {this.AnoModelo} \nAno da Fabricação: {this.AnoFabricacao} \nCor: {this.Cor}, \nVendido: {this.Vendido}";
        }

    }
}
