namespace SistemaEstacionamento.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        
        private List<string> veiculos = new List<string>(); //variavel tipo list
        
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            string placa = "" ;

            Console.WriteLine("Informe sua placa para estacionar: ");
            placa = Console.ReadLine();

            veiculos.Add(placa); //adicionando a placa na lista de veiculos
            Console.WriteLine("Placa cadastrada com sucesso");

        }


        public void RemoveVeiculo()
        {
            string placa = "";
            Console.WriteLine("Informe a placa estacionada para remover");
            placa = Console.ReadLine();

           if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
           {    
            int horas = 0;
            decimal valorTotal= 0;
                Console.WriteLine("Digite a quantidade de horas que o veiculo permaneceu estacionado: ");
                horas = int.Parse(Console.ReadLine());
                 //calculando 
                valorTotal = (precoInicial + precoPorHora * horas);

                veiculos.Remove(placa); //remove da lista
                Console.WriteLine("$ O veiculo {placa} foi removido e o preço total foi de : R$ {valorTotal}");

           } 

           else
           {
                Console.WriteLine("Desculpe, veiculo não está estacionado aqui. Confira a placa digitada.");
           }


        }


        public void ListarVeiculo()
        {

        }

    }
}