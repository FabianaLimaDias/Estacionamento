using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    public class Estacionamento1
    {
        private decimal precoInicial = 0; //* privada para limitar acesso
        private decimal precoPorHora = 0; //* privada para limitar acesso
        private List<string> veiculos = new List<string>();//* privada LISTA para limitar acesso


        //construtor criado aonde obrigatório passar preço inicial e preço por hora
        public Estacionamento1 (decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        //metodo adicionar veiculos
        public void AdicionarVeiculo()
        {
            
            Console.WriteLine("Digite a placa do veículo para estacionar:");
             string placa = Console.ReadLine();

            veiculos.Add(placa);//variavel da lista e add e dentro paremtro placa digitada
          
            
            
        }

        //metodo para remover veiculo
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();
            
            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = (precoInicial + precoPorHora) * horas;

                veiculos.Remove(placa.ToUpper());
                

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        //metodo para listar veiculos
        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                foreach (var consulta in veiculos)
                {
                    Console.WriteLine(consulta);
                }
               
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
