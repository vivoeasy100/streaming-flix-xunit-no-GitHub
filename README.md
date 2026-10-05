# 🎬 StreamingFlix - Garantia da Qualidade de Software

Projeto desenvolvido para a disciplina de **Garantia da Qualidade de Software / Gestão e Qualidade de Software**, focado na implementação de regras de negócio em C# .NET 10 e criação de suítes de testes unitários parametrizados com **xUnit**.

---

## 🎓 Identificação do Aluno

- **Nome:** Fernando Almeida de Oliveira Braga
- **RA:** 326132695
- **Disciplina:** Garantia da Qualidade de Software / Gestão e Qualidade de Software
- **Professor:** Daniel Henrique Matos de Paiva

---

## 📌 Visão Geral da Aplicação

O **StreamingFlix** é uma plataforma de streaming de vídeo que possui regras de negócio essenciais para:
1. **Classificação de Planos por Qualidade/Telas:** Determina a categoria do plano (`BÁSICO`, `PADRÃO`, `PREMIUM`) de acordo com a quantidade de telas simultâneas contratadas.
2. **Cálculo de Mensalidade com Desconto:** Aplica descontos progressivos na mensalidade conforme o período de fidelidade (10% de desconto para contratos de 6 a 11 meses e 20% de desconto para 12 meses ou mais).
3. **Controle de Acesso a Conteúdo Adulto:** Valida a permissão de acesso considerando a idade do usuário e o status do controle parental.

---

## 🛠️ Requisitos Técnicos

- **Linguagem:** C# (.NET 10.0)
- **Framework de Testes:** xUnit (`xunit` 2.9.3)
- **Ferramentas de Execução:** .NET CLI (`dotnet`)

---

## 🚀 Instruções de Execução

### 1. Clonar o Repositório

```bash
git clone https://github.com/vivoeasy100/streaming-flix-xunit-no-GitHub.git
cd streaming-flix-xunit-no-GitHub
```

### 2. Rodar a Aplicação Console

Para executar a aplicação principal:

```bash
dotnet run --project StreamingFlix.App
```

---

## 🧪 Execução dos Testes Unitários

Para rodar a suíte de testes parametrizados via CLI:

```bash
dotnet test
```

### Cobertura dos Testes Parametrizados (`PlanoStreamingServiceTests.cs`)

A suíte de testes utiliza os atributos `[Theory]` e `[InlineData]` do xUnit para garantir cobertura das seguintes regras de negócio:

1. **Classificação de Planos (`ObterClassificacaoPorQualidade`):**
   - `1 tela` ➔ `"BÁSICO"`
   - `2 telas` ➔ `"PADRÃO"`
   - `4 telas` ➔ `"PREMIUM"`

2. **Cálculo de Mensalidades com Desconto (`CalcularMensalidadeComDesconto`):**
   - `50 base, 1 mês` ➔ `50` (Sem desconto)
   - `50 base, 6 meses` ➔ `45` (10% de desconto)
   - `50 base, 12 meses` ➔ `40` (20% de desconto)

3. **Validação de Acesso a Conteúdo Adulto (`PodeAcessarConteudoAdulto`):**
   - `Idade 20, Controle Parental inativo (false)` ➔ `true` (Acesso permitido)
   - `Idade 20, Controle Parental ativo (true)` ➔ `false` (Acesso negado)
   - `Idade 16, Controle Parental inativo (false)` ➔ `false` (Acesso negado)

---

## 📜 Licença

Este projeto está licenciado sob a Licença MIT - consulte o arquivo [LICENSE](file:///e:/streaming-flix-xunit-no-GitHub/streaming-flix-xunit-no-GitHub/LICENSE) para mais detalhes.