using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;
public class ValidacoesListaTests
{
    private readonly ValidacoesLista _validacoes = new();

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        // Arrange
        List<int> lista = new() { 5, -1, -8, 9 };
        List<int> resultadoEsperado = new() { 5, 9 };

        // Act
        List<int> resultado = _validacoes.RemoverNumerosNegativos(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        // Arrange
        List<int> lista = new() { 5, -1, -8, 9 };
        int numeroParaProcurar = 9;

        // Act
        bool resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        //TODO: Implementar método de teste

        // Arrange
        List<int> lista = new() { 5, -1, -8, 9 };
        int numeroParaProcurar = 10;

        // Act
        bool resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.False(resultado);
    }

    [Fact] //TODO: Corrigir a anotação [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
        //TODO: Implementar método de teste

        // Arrange
        List<int> lista = new() { 5, 7, 8, 9 };
        List<int> resultadoEsperado = new() { 10, 14, 16, 18 };

        // Act
        List<int> resultado = _validacoes.MultiplicarNumerosLista(lista, 2);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
        //TODO: Implementar método de teste

        // Arrange
        List<int> lista = new() { 5, -1, -8, 9 };

        // Act
        int resultado = _validacoes.RetornarMaiorNumeroLista(lista);

        // Assert
        //TODO: Corrigir o Assert.Equal com base no retorno da chamada ao método
        Assert.Equal(9, resultado);
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {
        //TODO: Implementar método de teste

        // Arrange
        List<int> lista = new() { 5, -1, -8, 9 };

        // Act
        int resultado = _validacoes.RetornarMenorNumeroLista(lista);

        // Assert
        //TODO: Corrigir o Assert.Equal com base no retorno da chamada ao método
        Assert.Equal(-8, resultado);
    }
}