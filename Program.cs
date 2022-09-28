using SistemaEstacionamento.Models;
// See https://aka.ms/new-console-template for more information

string nomeDonoVeiculo = "";
DateTime data = DateTime.Now;
decimal precoInicial = 0;
decimal precoPorHora = 0;


Console.WriteLine("Bem Vindo ao Estacionamento! " +data);

Console.WriteLine("Informe o seu Nome: ");
nomeDonoVeiculo = Console.ReadLine();
Console.WriteLine("Digite o preço inicial: ");
precoInicial = decimal.Parse(Console.ReadLine());
Console.WriteLine("Digite o preço por hora: ");
precoPorHora = decimal.Parse(Console.ReadLine());

//instanciando a classe estacionamento
Estacionamento estacio = new Estacionamento( precoInicial, precoPorHora);


string opc = string.Empty;
bool exibeMenu = true;
//menu
while (exibeMenu)
{
    Console.Clear();
    Console.WriteLine("Digite uma opção: ");
    Console.WriteLine("1- Cadastrar Veiculos");
    Console.WriteLine("2- Remover Veiculos");
    Console.WriteLine("3- Listar Veiculos");
    Console.WriteLine("4- Sair");
    

    switch (Console.ReadLine())
    {
        case "1":
            estacio.AdicionarVeiculo(); //metodo para adicionar o veiculo
            break;

        case "2":
            estacio.RemoveVeiculo(); //metodo para remover o veiculo
            break;

        case "3":
            estacio.ListarVeiculo(); //metodo para listar veiculos
            break;

        case "4":
            exibeMenu = false;
            break;

        default:
            Console.WriteLine("Opçao invalida!");
            break;
    }

        Console.ReadLine();
}