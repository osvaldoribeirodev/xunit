namespace CShp_XUnitTest;
using XUnitMoq.CShp_UnitTestMoq;
using Moq;
using Xunit;
using System;
public class CalculoUnitTest
{
    [Fact]
    public void Somar_Dois_Numeros()
    {
        // Arrange
        Moq.Mock<ICalculadora> mock = new Moq.Mock<ICalculadora>();
        mock.Setup(x => x.Calcular(It.IsAny<string>(), It.IsAny<double>(), It.IsAny<double>())).Returns(("somar", 7.7));

        MaquinaCalculadora maqCalc = new MaquinaCalculadora(mock.Object);

        // Act
        (string operacao, double resultado) op = maqCalc.Calcular("somar", 3.2, 4.5);

        // Assert
        Assert.Equal("somar", op.operacao);
        Assert.Equal(7.7, op.resultado);
    }

    [Fact]
    public void Subtrair_Dois_Numeros()
    {
        // Arrange
        Moq.Mock<ICalculadora> mock = new Moq.Mock<ICalculadora>();
        mock.Setup(x => x.Calcular(It.IsAny<string>(), It.IsAny<double>(), It.IsAny<double>())).Returns(("subtrair", -1.3));
        MaquinaCalculadora maqCalc = new MaquinaCalculadora(mock.Object);
        // Act
        (string operacao, double resultado) op = maqCalc.Calcular("subtrair", 3.2, 4.5);
        // Assert
        Assert.Equal("subtrair", op.operacao);
        Assert.Equal(-1.3, op.resultado);
    }

    [Fact]
    public void Multiplicar_Dois_Numeros()
    {
        // Arrange
        Moq.Mock<ICalculadora> mock = new Moq.Mock<ICalculadora>();
        mock.Setup(x => x.Calcular(It.IsAny<string>(), It.IsAny<double>(), It.IsAny<double>())).Returns(("multiplicar", 14.4));
        MaquinaCalculadora maqCalc = new MaquinaCalculadora(mock.Object);
        // Act
        (string operacao, double resultado) op = maqCalc.Calcular("multiplicar", 3.2, 4.5);
        // Assert
        Assert.Equal("multiplicar", op.operacao);
        Assert.Equal(14.4, op.resultado);
    }

    [Fact]
    public void Dividir_Dois_Numeros()
    {
        // Arrange
        Moq.Mock<ICalculadora> mock = new Moq.Mock<ICalculadora>();
        mock.Setup(x => x.Calcular(It.IsAny<string>(), It.IsAny<double>(), It.IsAny<double>())).Returns(("dividir", 0.71));
        MaquinaCalculadora maqCalc = new MaquinaCalculadora(mock.Object);
        // Act
        (string operacao, double resultado) op = maqCalc.Calcular("multiplicar", 3.2, 4.5);
        // Assert
        Assert.Equal("dividir", op.operacao);
        Assert.Equal(0.71, op.resultado);
    }

    /*
    Neste caso de teste de unidade estamos somando os números 3.2 e 4.5 e esperamos o resultado igual a 7.7.
    Estamos criando um objeto mock usando a interface ICalculadora e a seguir especificando uma configuração 
    para invocar a operação 'somar' esperando o retorno igual a 7.7.
    Depois criamos uma instância da classe MaquinaCalculadora() passando o objeto mocado e os números para realizar a operação.
    Ao final definimos o que esperamos obter com a operação e resultado para indicar que o teste passou.
    */
}