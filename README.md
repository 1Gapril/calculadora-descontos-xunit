🔍 Diferença entre [Fact] e [Theory]
[Fact]: É utilizado para testes unitários tradicionais e únicos, que não recebem parâmetros externos. Ele executa uma única vez validando um cenário específico.
[Theory]: É utilizado para testes parametrizados. Ele permite executar a mesma lógica de teste múltiplas vezes passando conjuntos diferentes de dados fornecidos através dos atributos [InlineData], evitando duplicação de código.
📋 Métodos Implementados (DescontoService.cs)
ObterCategoriaCliente(int totalCompras): Retorna "BRONZE" (< 5), "PRATA" (entre 5 e 10) ou "OURO" (> 10).
CalcularDescontoPorPercentual(int valorOriginal, int percentualDesconto): Aplica o percentual de desconto sobre o valor original e retorna o valor final.
EValidoParaCupom(int idade, bool primeiraCompra): Retorna true se o cliente tiver 18 anos ou mais e se for a primeira compra.
🚀 Como Executar os Testes
Certifique-se de ter o .NET 10 SDK instalado, abra o terminal na pasta raiz da solução e execute:

dotnet test
