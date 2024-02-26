using TestesUnitarios.Desafio.Console.Interfaces;
using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Console.Models
{
    public class MenuDeListas : IMenuDeListas
    {
        private readonly ValidacoesLista _validacoes;
        private readonly List<int> _lista;
        private string? _input;
        private int _num;

        public MenuDeListas()
        {
            _validacoes = new ValidacoesLista();
            _lista = new List<int>();
            _input = "";
        }

        public List<int> CadastrarLista()
        {
            System.Console.WriteLine("Primeiro vamos preencher uma lista para realizar testes");

            do
            {
                System.Console.WriteLine("Digite um número e pressione enter para adicionar à lista ou digite 'exit' para sair:");
                _input = System.Console.ReadLine();

                if (_input != "exit" && int.TryParse(_input, out _num))
                    _lista.Add(_num);
                else if (_input != "exit")
                    System.Console.WriteLine("Entrada inválida. Por favor, insira um número válido ou 'exit' para sair.");
            } while (_input != "exit");

            return _lista;
        }

        public void ExibirMenuDeListas()
        {
            CadastrarLista();

            System.Console.WriteLine();
            System.Console.WriteLine("==================== TESTAR LISTAS ====================");
            System.Console.WriteLine();
            System.Console.WriteLine("1-Remover Numeros Negativos \n2-Buscar Determinado número \n3-Multiplicar Numeros da Lista \n4-Retornar Maior Numero da Lista \n5-Retornar Menor Numero da Lista \n0-Voltar ");
            System.Console.WriteLine();
            System.Console.WriteLine("=======================================================");
            System.Console.WriteLine();

            string? opcao = System.Console.ReadLine();

            switch (opcao)
            {
                case "1":

                    ListaCadastrada();
                    List<int> listaPositivos = _validacoes.RemoverNumerosNegativos(_lista);

                    System.Console.WriteLine("Resultado:");
                    System.Console.WriteLine("Lista de números positivos da lista:");
                    System.Console.WriteLine();
                    foreach (var nums in listaPositivos)
                        System.Console.WriteLine(nums);
                    System.Console.WriteLine();
                    _lista.Clear();
                    break;

                case "2":

                    System.Console.WriteLine("Informe o número que deseja buscar na lista:");
                    _num = Convert.ToInt32(System.Console.ReadLine());
                    bool encontrado = _validacoes.ListaContemDeterminadoNumero(_lista, _num);
                    ListaCadastrada();
                    System.Console.WriteLine("Resultado:");
                    System.Console.WriteLine(encontrado ? $"O número {_num} foi encontrado na lista !" : $"O número {_num} não foi encontrado na lista !");
                    break;

                case "3":

                    System.Console.WriteLine("Informe um multiplicador para multiplicar pelos números da lista:");
                    _num = Convert.ToInt32(System.Console.ReadLine());

                    List<int> multiplicados = _validacoes.MultiplicarNumerosLista(_lista, _num);
                    ListaCadastrada();
                    System.Console.WriteLine("Resultado:");
                    System.Console.WriteLine($"Lista de números após a multiplicação x{_num}:");
                    System.Console.WriteLine();
                    foreach (var num in multiplicados)
                        System.Console.WriteLine(num);
                    System.Console.WriteLine();
                    _lista.Clear();
                    break;

                case "4":

                    _num = _validacoes.RetornarMaiorNumeroLista(_lista);
                    ListaCadastrada();
                    System.Console.WriteLine("Resultado:");
                    System.Console.WriteLine($"O maior número da lista é: {_num}");
                    break;

                case "5":

                    _num = _validacoes.RetornarMenorNumeroLista(_lista);
                    ListaCadastrada();
                    System.Console.WriteLine("Resultado:");
                    System.Console.WriteLine($"O menor número da lista é: {_num}");
                    break;

                case "0":

                    System.Console.WriteLine();
                    System.Console.WriteLine("retornando ...");
                    System.Console.WriteLine();
                    break;

                default:

                    System.Console.WriteLine("opção inválida !");
                    break;
            }
        }

        public void ListaCadastrada()
        {
            System.Console.WriteLine("Resultado:");
            System.Console.WriteLine("Lista de números fornecida:");
            System.Console.WriteLine();
            foreach (var nums in _lista)
                System.Console.WriteLine(nums);
            System.Console.WriteLine();
        }
    }
}