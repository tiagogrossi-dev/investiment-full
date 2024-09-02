## Execução ##
Para execução do projeto/api basta selecionar InvestmentApi e definir como projeto de inicialização

## Testes ##
Para realização dos testes basta ir em Teste no Visual Studio e selecionar "Executar todos os testes"

Método Testado:

CalculateInvestment(InvestmentRequest request)

Descrição do Teste:

Nome do Teste: CalculateInvestment_ReturnsBadRequest_WhenInvalidInput
Objetivo: Verificar se o método CalculateInvestment retorna um resultado adequado quando a entrada fornecida é inválida.
Detalhes do Teste:

Configuração (Arrange):

Foi criado um objeto InvestmentRequest com valores inválidos para o teste. Especificamente, o valor inicial (InitialValue) é -1000, o que é um valor negativo e não aceitável para um investimento, e o número de meses (Months) é 1.
Ação (Act):

O método CalculateInvestment da instância _service foi chamado com o objeto InvestmentRequest criado anteriormente.
Verificação (Assert):

A verificação é feita comparando o resultado retornado pelo método CalculateInvestment com o tipo esperado InvestmentResult. A comparação é feita usando o método Equals.