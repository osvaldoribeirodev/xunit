xUnit - Conceitos básicos

No xUnit precisamos decorar os métodos de teste com o atributo [Fact], que é usado pelo xUnit para marcar os métodos de testes. Além dos métodos de testes, também podemos ter vários métodos auxiliares na classe de teste.

Com o XUnit para tornar um método comum em método de testes basta adicionar [Fact] ou [Theory] acima de sua assinatura, os atributos diferem apenas no seguinte, para testes sem parâmetros deve-se usar [Fact], para testes como parâmetros utiliza-se o [Theory].

O atributo [Theory] indica um teste parametrizado que é verdadeiro para um subconjunto de dados. Esses dados podem ser fornecidos de várias maneiras, mas o mais comum é com um atributo [InlineData]. Assim este atributo permite executar um método de teste várias vezes passando diferentes valores a cada vez como parâmetros.

Podemos ainda desativar um teste por qualquer motivo. Para isso basta definir a propriedade Skip no atributo Fact com o motivo que você desativou o teste (o motivo não é exibido).

        [Fact(Skip = "Teste ainda não disponível")]
        public void Teste()
        {
        }
Á medida que o número de seus testes aumenta, você pode organizá-los em grupos para que poder executar os testes juntos. O atributo [Trait] permite organizar os testes em grupos, criando nomes de categoria e atribuindo valores a eles.

        [Fact(DisplayName = "Teste Numero 2")]
        [Trait("Calculo", "Somar")]
        public void Somar_DoisNumeros_RetornaNumero()
        { }

Ao escrever testes unitários, em geral seguimos o princípio AAA :  Act, Arrange e Assert (Organizar, Agir e Assertir):

Arrange - É aqui que você normalmente prepara tudo para o teste, em outras palavras, prepara a cena para testar (criar os objetos e configurá-los conforme necessário)

Act - É onde o método que estamos testando será executado;

Assert - Esta é a parte final do teste em que comparamos o que esperamos que aconteça com o resultado real da execução do método de teste;

Os nomes dos métodos de teste devem ser tão descritivos quanto possível. Na maioria dos casos, é possível nomear o método para que nem seja necessário ler o código real para entender o que está sendo testado.

No exemplo, usamos a seguinte convenção de nomenclatura :

1 - A primeira parte do nome representa o nome do método que está sendo testado;
2-  A segunda parte do nome nos informa mais sobre o cenário de teste;
3-  A  última parte do nome é o resultado esperado;

Exemplo : Soma_DoisNumerosInteiros_RetornaNumeroInteiro

Fonte:
    https://www.macoratti.net/19/09/cshp_unitest1.htm

/*************************************************************************************************/

Testes Unitários com XUnit e Moq

O que é Moq ?
https://github.com/Moq/moq4

Moq é uma biblioteca para mocar objetos para a plataforma .NET desenvolvida para tirar o máximo proveito de recursos como Linq, 
árvores de expressão, expressões lambdas, etc. Assim, ela suporta a mocagem de interfaces bem como classes. 
Sua API é extremamente simples e direta, e não requer nenhum conhecimento ou experiência prévia com os conceitos de mocking.