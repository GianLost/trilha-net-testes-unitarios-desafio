using TestesUnitarios.Desafio.Console.Interfaces;
using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Console.Models
{
    public class MenuDeStrings : IMenuDeStrings
    {
        private readonly ValidacoesString _validacoes;
        private string? _input;

        public MenuDeStrings()
        {
            _validacoes = new ValidacoesString();
            _input = "";
        }

        public string CadastrarStrings()
        {
            System.Console.WriteLine("Primeiro vamos preencher uma lista para realizar testes");

            while(_input != "exit")
            {
                System.Console.WriteLine("Digite um número e pressione enter para adicionar à lista ou digite 'exit' para sair:");
                _input = System.Console.ReadLine();

                if (_input != "exit")
                {
                    
                }
            }

            return _input;
        }

        public void ExibirMenuDeStrings()
        {
            CadastrarStrings();

            System.Console.WriteLine();
            System.Console.WriteLine("==================== TESTAR LISTAS ====================");
            System.Console.WriteLine();
            System.Console.WriteLine("1-Remover Numeros Negativos \n2-Buscar Determinado número \n3-Multiplicar Numeros da Lista \n4-Retornar Maior Numero da Lista \n5-Retornar Menor Numero da Lista \n0-sair ");
            System.Console.WriteLine();
            System.Console.WriteLine("=======================================================");
            System.Console.WriteLine();

            string? opcao = System.Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "0":
                    System.Console.WriteLine();
                    System.Console.WriteLine("saindo...");
                    System.Console.WriteLine();
                    break;
                default:
                    System.Console.WriteLine("opção inválida !");
                    break;
            }
        }

        public void StringCadastrada()
        {
            throw new NotImplementedException();
        }
    }
}