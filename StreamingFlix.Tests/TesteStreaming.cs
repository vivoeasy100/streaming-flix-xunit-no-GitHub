using Xunit;
using StreamingFlix.App;

namespace StreamingFlix.Tests;

public class UnitTest1
{
    private readonly PlanoStreamingService _service = new PlanoStreamingService();

    [Theory]
    [InlineData(1, "BÁSICO")]
    [InlineData(2, "PADRÃO")]
    [InlineData(4, "PREMIUM")]
    public void ObterClassificacaoPorQualidade_DeveRetornarDescricaoCorreta(int telasSimultaneas, string descricaoEsperada)
    {
        string resultado = _service.ObterClassificacaoPorQualidade(telasSimultaneas);
        Assert.Equal(descricaoEsperada, resultado);
    }

    [Theory]
    [InlineData(50, 1, 50)]  // sem desconto
    [InlineData(50, 6, 45)]  // 10% de desconto
    [InlineData(50, 12, 40)] // 20% de desconto
    public void CalcularMensalidadeComDesconto_DeveAplicarDescontoPelosMesesContratados(int valorBase, int mesesContratados, int valorEsperado)
    {
        int resultado = _service.CalcularMensalidadeComDesconto(valorBase, mesesContratados);
        Assert.Equal(valorEsperado, resultado);
    }

    [Theory]
    [InlineData(20, false, true)]  // Maior de idade, sem restrição -> true
    [InlineData(20, true, false)]  // Maior de idade, com restrição -> false
    [InlineData(16, false, false)] // Menor de idade -> false
    public void PodeAcessarConteudoAdulto_DeveValidarIdadeEControleParental(int idade, bool controleParentalAtivo, bool resultadoEsperado)
    {
        bool resultado = _service.PodeAcessarConteudoAdulto(idade, controleParentalAtivo);
        Assert.Equal(resultadoEsperado, resultado);
    }
}