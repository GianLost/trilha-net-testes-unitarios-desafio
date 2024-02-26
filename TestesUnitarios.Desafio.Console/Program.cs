using TestesUnitarios.Desafio.Console.Interfaces;
using TestesUnitarios.Desafio.Console.Models;

string? opcao;

do
{
    Console.WriteLine();
    Console.WriteLine("============================ MENU ============================");
    Console.WriteLine();
    Console.WriteLine("Digite um número e pressione enter para selecionar a opção !");
    Console.WriteLine();
    Console.WriteLine("1-Testar Validações de Lista \n2-Testar validações de String \n0-Sair");
    Console.WriteLine();
    Console.WriteLine("==============================================================");
    Console.WriteLine();

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":

            IMenuDeListas menu = new MenuDeListas();
            menu.ExibirMenuDeListas();
            break;

        case "2":

            IMenuDeStrings menuStr = new MenuDeStrings();
            menuStr.ExibirMenuDeStrings();
            break;

        case "0":

            Console.WriteLine();
            Console.WriteLine("saindo...");
            Console.WriteLine();
            break;

        default:

            Console.WriteLine("opção inválida !");
            break;
    }

} while (opcao != "0");