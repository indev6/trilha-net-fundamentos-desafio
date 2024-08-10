using System.Reflection;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        public List<string> veiculos = new List<string>();
    
        

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placaAdd = Console.ReadLine();
            veiculos.Add(placaAdd);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            
            string placaRemove = "";
            placaRemove = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placaRemove.ToUpper()))
            {

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                                
                int horas = 0;
                horas = Convert.ToInt32(Console.ReadLine());
                
                decimal valorTotal = precoInicial + precoPorHora * horas; 
                veiculos.Remove(placaRemove);

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*
                

                Console.WriteLine($"O veículo {placaRemove} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados

                int contadorForeach = 0;
                foreach(string item in veiculos)
                {
                Console.WriteLine($"Posição nº {contadorForeach} - {item}");
                contadorForeach++;
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
