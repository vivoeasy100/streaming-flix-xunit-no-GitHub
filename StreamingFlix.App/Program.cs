using StreamingFlix.App;

Console.WriteLine("=== StreamingFlix ===");

var service = new PlanoStreamingService();

string plano = service.ObterClassificacaoPorQualidade(2);
Console.WriteLine($"Classificação (2 telas): {plano}");

int valorComDesconto = service.CalcularMensalidadeComDesconto(50, 12);
Console.WriteLine($"Valor com desconto (50 base, 12 meses): R$ {valorComDesconto}");

bool podeAcessar = service.PodeAcessarConteudoAdulto(20, false);
Console.WriteLine($"Acesso conteúdo adulto (20 anos, sem restrição): {podeAcessar}");
