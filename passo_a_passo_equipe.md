# 🚀 Guia de Commits da Equipe - StreamingFlix

Para garantir que todos os 3 desenvolvedores apareçam na seção **"Contributors"** do repositório no GitHub (conforme a exigência da página 4 do PDF), cada membro da equipe precisa realizar pelo menos um commit utilizando sua própria conta.

Siga exatamente o passo a passo abaixo para cada membro:

---

## 👨‍💻 Desenvolvedor 1: `vivoeasy100`
**Foco da Tarefa:** Remover o arquivo de teste duplicado (`TesteStreaming.cs`).

1. **Configure sua conta do GitHub no terminal:**
   ```bash
   git config user.name "vivoeasy100"
   git config user.email "SEU_EMAIL_AQUI@exemplo.com"
   ```

2. **Remova o arquivo duplicado:**
   Apague o arquivo `TesteStreaming.cs` que está dentro da pasta `StreamingFlix.Tests`. (Pode apagar clicando com o botão direito e deletando no Windows ou VS Code).

3. **Faça o Commit e Push:**
   ```bash
   git add .
   git commit -m "chore: removendo arquivo de testes duplicado"
   git push origin main
   ```

---

## 👨‍💻 Desenvolvedor 2: `LuchMiranda` (Lucas H. Miranda)
**Foco da Tarefa:** Atualizar os nomes da equipe no `README.md`.

1. **Baixe as atualizações e configure sua conta no terminal:**
   ```bash
   git pull origin main
   git config user.name "LuchMiranda"
   git config user.email "SEU_EMAIL_AQUI@exemplo.com"
   ```

2. **Altere o código:**
   Abra o arquivo `README.md`. Vá até a seção **"🎓 Identificação do Aluno"** e altere para que contenha o nome de todos os membros do grupo.

3. **Faça o Commit e Push:**
   ```bash
   git add README.md
   git commit -m "docs: atualizando readme com os membros da equipe"
   git push origin main
   ```

---

## 👨‍💻 Desenvolvedor 3: `1Gapril`
**Foco da Tarefa:** Ajustar os links de clonagem e revisar o arquivo de documentação.

1. **Baixe as atualizações e configure sua conta no terminal:**
   ```bash
   git pull origin main
   git config user.name "1Gapril"
   git config user.email "SEU_EMAIL_AQUI@exemplo.com"
   ```

2. **Altere o código:**
   No arquivo `README.md`, verifique se o link de clonagem do GitHub aponta para o repositório público final correto (que, segundo o PDF, deveria se chamar apenas `streaming-flix-xunit`). Altere a URL do repositório no README ou apenas adicione uma quebra de linha em branco no final do arquivo para registrar sua contribuição.

3. **Faça o Commit e Push:**
   ```bash
   git add README.md
   git commit -m "fix: pequenos ajustes na url do repositorio"
   git push origin main
   ```

---

### ✅ Verificação Final (Para todos)
Após os três realizarem os passos acima, abram a página do repositório público no GitHub. 
Na barra lateral direita do repositório, vocês deverão ver uma seção chamada **"Contributors"** exibindo o número **3** com as fotos dos três membros!
