using XUnit.CShp_Calculos;

namespace XUnit.CShp_CalculosTest;
public class CalculoUnitTest
{
    [Fact]
    public void Somar_DoisDouble_RetornarDouble()
    {
        // Arrange
        var num1 = 2.9;
        var num2 = 3.1;
        var valorEsperado = 6;

        // Act
        var soma = Calculo.Somar(num1, num2);

        // Assert
        // error CS0619: "Assert.Equals(object, object)" é obsoleto: "This is an override of Object.Equals(). Call Assert .Equal() instead."
        Object.Equals(valorEsperado, soma);
    }

    [Fact]
    public void Subtrair_DoisDouble_RetornaDouble()
    {
        // Arrange  
        var num1 = 2.9;
        var num2 = 3.1;
        var valorEsperado = -0.2;
        // Act  
        var subtracao = Calculo.Subtrair(num1, num2);
        //Assert  
        Object.Equals(valorEsperado, subtracao);
    }

    [Fact]
    public void Multiplicar_DoisDouble_RetornaDouble()
    {
        // Arrange  
        var num1 = 2.9;
        var num2 = 3.1;
        var valorEsperado = 8.99;
        // Act  
        var mult = Calculo.Multiplicar(num1, num2);
        //Assert  
        Object.Equals(valorEsperado, mult);
    }

    [Fact]
    public void Dividir_DoisDouble_RetornaDouble()
    {
        // Arrange  
        var num1 = 2.9;
        var num2 = 3.1;
        var valorEsperado = 0.94; //Rounded value  
                                  // Act  
        var div = Calculo.Dividir(num1, num2);
        //Assert  
        Object.Equals(valorEsperado, div);
    }

    /*
    Agora ao invés de especificar os valores para somar (num1 e num2) no corpo do teste, passamos os valores como parâmetros para o teste.
    Passamos também o resultado esperado do cálculo para usar na chamda do Assert.Equal().
    Aqui os dados dados são fornecidos pelo atributo [InlineData] onde cada instância de [InlineData] criará uma execução separada 
    do método Somar_DoisNumerosRelativos_RetornaNumeroRelativo.

    Os valores passados ​​no construtor de [InlineData] são usados ​​como parâmetros para o método, e, a ordem dos parâmetros no atributo 
    corresponde à ordem em que eles são fornecidos ao método
    */
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(-4, -6, -10)]
    [InlineData(-2, 2, 0)]
    [InlineData(int.MinValue, -1, int.MaxValue)]
    public void Somar_DoisNumerosRelativos_RetornaNumeroRelativo(int num1, int num2, int valorEsperado)
    {
        //Act
        var resultado = Calculo.Somar(num1, num2);
        //Assert
        Object.Equals(valorEsperado, resultado);
    }
}