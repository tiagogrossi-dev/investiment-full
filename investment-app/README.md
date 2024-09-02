## Para execução do projeto
Basta digitar no console `ng serve`. Abra o navegador e cole o endereço a seguir `http://localhost:4200/`.

## Para execução dos testes
Basta digitar no console `ng test` onde o mesmo ira gerar um relatório final automatico abrindo uma pagina no navegador.

## Testes realizados
Os testes unitários foram realizados para validar o correto funcionamento do componente InvestimentFormComponent na aplicação Angular. Os testes utilizam o framework de testes do Angular para garantir que o componente se comporte conforme o esperado em condições controladas.

Testes Realizados
O arquivo de teste contém a configuração e um teste básico para o componente InvestimentFormComponent. Abaixo está a descrição detalhada dos testes:

1. Configuração do Ambiente de Teste
Configuração do TestBed:
O TestBed foi configurado para criar um ambiente de teste para o InvestimentFormComponent. A configuração incluiu:
Declarações: O componente InvestimentFormComponent foi declarado para que possa ser instanciado e testado.
Imports: Foram importados módulos essenciais para o componente, incluindo:
ReactiveFormsModule: Para permitir o uso de formulários reativos no componente.
HttpClientTestingModule: Para simular interações com serviços HTTP sem fazer chamadas reais.
Providers: O InvestmentService foi incluído como um provedor para permitir a injeção de dependências no componente.

2. Criação e Inicialização do Componente
Criação do Componente:
A instância do InvestimentFormComponent foi criada usando TestBed.createComponent().
O componente foi inicializado e as mudanças detectadas foram acionadas com fixture.detectChanges() para garantir que o componente e sua visualização estejam atualizados e prontos para os testes.

3. Teste Realizado
Teste de Criação do Componente:
Objetivo: Verificar se o componente InvestimentFormComponent é criado corretamente.
Método: O teste usa expect(component).toBeTruthy() para validar que o componente foi instanciado com sucesso.
Resultado Esperado: O teste deve passar se o componente for criado e não for null ou undefined.
