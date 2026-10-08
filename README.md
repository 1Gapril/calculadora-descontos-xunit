# CALCULADORA DE DESCONTOS - XUNIT & THEORY (.NET 10)

Repositório desenvolvido para a atividade prática da disciplina de **Gestão e Qualidade de Software**, sob orientação do Professor Daniel Henrique Matos de Paiva.

O objetivo principal deste projeto é demonstrar a diferença prática entre testes estáticos (`[Fact]`) e testes parametrizados (`[Theory]` com `[InlineData]`) utilizando o framework xUnit no .NET 10.

## 🔍 DIFERENÇA ENTRE [FACT] E [THEORY]

- **`[Fact]`**: Utilizado para testes unitários tradicionais e únicos, que não recebem parâmetros externos. Ele executa uma única vez validando um cenário específico.
- **`[Theory]`**: Utilizado para testes parametrizados. Permite executar a mesma lógica de teste múltiplas vezes passando conjuntos diferentes de dados fornecidos através dos atributos `[InlineData]`, evitando duplicação de código.

## 📋 MÉTODOS IMPLEMENTADOS (DESCONTOSERVICE.CS)

O serviço contém as seguintes implementações:

1. **ObterCategoriaCliente(int totalCompras)**:
   - Retorna "BRONZE" (< 5 compras).
   - Retorna "PRATA" (entre 5 e 10 compras).
   - Retorna "OURO" (> 10 compras).

2. **CalcularDescontoPorPercentual(int valorOriginal, int percentualDesconto)**:
   - Aplica o percentual de desconto sobre o valor original e retorna o valor final.

3. **EValidoParaCupom(int idade, bool primeiraCompra)**:
   - Retorna `true` se o cliente tiver 18 anos ou mais E for a sua primeira compra.

## 🚀 COMO EXECUTAR OS TESTES

Certifique-se de ter o **.NET 10 SDK** instalado. Abra o terminal na pasta raiz da solução e execute:

```bash
dotnet test
