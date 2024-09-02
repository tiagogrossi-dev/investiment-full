## Execu��o ##
Para execu��o do projeto/api basta selecionar InvestmentApi e definir como projeto de inicializa��o

## Testes ##
Para realiza��o dos testes basta ir em Teste no Visual Studio e selecionar "Executar todos os testes"

M�todo Testado:

CalculateInvestment(InvestmentRequest request)

Descri��o do Teste:

Nome do Teste: CalculateInvestment_ReturnsBadRequest_WhenInvalidInput
Objetivo: Verificar se o m�todo CalculateInvestment retorna um resultado adequado quando a entrada fornecida � inv�lida.
Detalhes do Teste:

Configura��o (Arrange):

Foi criado um objeto InvestmentRequest com valores inv�lidos para o teste. Especificamente, o valor inicial (InitialValue) � -1000, o que � um valor negativo e n�o aceit�vel para um investimento, e o n�mero de meses (Months) � 1.
A��o (Act):

O m�todo CalculateInvestment da inst�ncia _service foi chamado com o objeto InvestmentRequest criado anteriormente.
Verifica��o (Assert):

A verifica��o � feita comparando o resultado retornado pelo m�todo CalculateInvestment com o tipo esperado InvestmentResult. A compara��o � feita usando o m�todo Equals.