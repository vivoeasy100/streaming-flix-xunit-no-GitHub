namespace StreamingFlix.App;

public class PlanoStreamingService
{
    /// <summary>
    /// Obter a classificação do plano baseada na quantidade de telas simultâneas.
    /// 1 tela -> "BÁSICO"
    /// 2 telas -> "PADRÃO"
    /// 4 ou mais telas -> "PREMIUM"
    /// </summary>
    public string ObterClassificacaoPorQualidade(int telasSimultaneas)
    {
        if (telasSimultaneas == 1)
            return "BÁSICO";
        if (telasSimultaneas == 2)
            return "PADRÃO";
        if (telasSimultaneas >= 4)
            return "PREMIUM";

        return "DESCONHECIDO";
    }

    /// <summary>
    /// Calcular valor da mensalidade com desconto baseado nos meses contratados.
    /// 6 a 11 meses -> 10% de desconto
    /// 12 ou mais meses -> 20% de desconto
    /// </summary>
    public int CalcularMensalidadeComDesconto(int valorBase, int mesesContratados)
    {
        if (mesesContratados >= 12)
        {
            return (int)(valorBase * 0.80);
        }
        if (mesesContratados >= 6)
        {
            return (int)(valorBase * 0.90);
        }
        return valorBase;
    }

    /// <summary>
    /// Valida se o usuário pode acessar conteúdo adulto.
    /// Retorna true apenas se a idade for >= 18 E o controle parental estiver false.
    /// </summary>
    public bool PodeAcessarConteudoAdulto(int idade, bool controleParentalAtivo)
    {
        return idade >= 18 && !controleParentalAtivo;
    }
}
