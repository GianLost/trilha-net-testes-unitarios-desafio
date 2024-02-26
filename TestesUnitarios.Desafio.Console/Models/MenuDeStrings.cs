using TestesUnitarios.Desafio.Console.Interfaces;
using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Console.Models
{
    public class MenuDeStrings : IMenuDeStrings
    {
        private readonly ValidacoesString _validacoes;
        private string? _texto;
        private string? _textoProcurado;

        public MenuDeStrings()
        {
            _validacoes = new ValidacoesString();
            _texto = "";
            _textoProcurado = "";
        }

        public string CadastrarStrings()
        {
            System.Console.WriteLine("Digite uma palavra, frase ou texto ou digite 'exit' para sair:");
            _texto = System.Console.ReadLine();
            
            if(string.IsNullOrEmpty(_texto) || _texto.Trim() == "exit")
            {
                string erro = "Nenhuma string foi fornecida!";
                System.Console.WriteLine();
                System.Console.WriteLine(erro);
                System.Console.WriteLine();
                return erro;
            }

            return _texto;  
        }

        public void ExibirMenuDeStrings()
        {
            CadastrarStrings();

            System.Console.WriteLine();
            System.Console.WriteLine("==================== TESTAR LISTAS ====================");
            System.Console.WriteLine();
            System.Console.WriteLine("1-Retornar Quantidade Caracteres \n2-Contem Caractere \n3-Texto Termina Com \n0-Voltar ");
            System.Console.WriteLine();
            System.Console.WriteLine("=======================================================");
            System.Console.WriteLine();

            string? opcao = System.Console.ReadLine();

            switch (opcao)
            {
                case "1":

                    System.Console.WriteLine();
                    System.Console.WriteLine($"String fornecida: \n{_texto}");
                    System.Console.WriteLine();

                    System.Console.WriteLine("Resultado:");
                    System.Console.WriteLine();
                    if(_texto != null)
                    {
                        int resultado = _validacoes.RetornarQuantidadeCaracteres(_texto);
                        System.Console.WriteLine($"A string possui {resultado} caracrtéres no total!");
                        System.Console.WriteLine();
                    }
                    break;

                case "2":

                    System.Console.WriteLine();
                    System.Console.WriteLine("digite algum caractére ou palavra encontrar na string passada.");
                    _textoProcurado = System.Console.ReadLine();

                    System.Console.WriteLine();
                    System.Console.WriteLine($"String fornecida: \n{_texto}");
                    System.Console.WriteLine();

                    if(_texto != null && _textoProcurado != null)
                    {
                        bool resultado = _validacoes.ContemCaractere(_texto, _textoProcurado);

                        if(!resultado)
                        {
                            System.Console.WriteLine();
                            System.Console.WriteLine($"O caracter/palavra \"{_textoProcurado}\" não foi encontrado na string passada!");
                            System.Console.WriteLine();
                        }
                        else
                        {
                            System.Console.WriteLine();
                            System.Console.WriteLine($"A string possui o caracter/palavra \"{_textoProcurado}\" !");
                            System.Console.WriteLine();
                        }
                    }
                    break;

                case "3":

                    System.Console.WriteLine();
                    System.Console.WriteLine("digite algum caractére ou palavra para verificar se a string termmina com ela.");
                    _textoProcurado = System.Console.ReadLine();
                    
                    System.Console.WriteLine();
                    System.Console.WriteLine($"String fornecida: \n{_texto}");
                    System.Console.WriteLine();

                    System.Console.WriteLine("Resultado:");
                    System.Console.WriteLine();
                    if(_texto != null && _textoProcurado != null)
                    {
                        bool resultado = _validacoes.TextoTerminaCom(_texto, _textoProcurado);

                        if(!resultado)
                        {
                            System.Console.WriteLine();
                            System.Console.WriteLine($"O texto fornecido não termina com \"{_textoProcurado}\" !");
                            System.Console.WriteLine();
                        }
                        else
                        {
                            System.Console.WriteLine();
                            System.Console.WriteLine($"O texto fornecido termina com \"{_textoProcurado}\" !");
                            System.Console.WriteLine();
                        }
                    }
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

    }
}