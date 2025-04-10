using Xunit;

namespace DZA.Cadastro.Test;


public class TestMock
{
    [Fact]
    public void Calculadora_Somar_RetornarValorSoma()
    {
        // Arrange


        // Act
        var resultado = (2 + 2);

        // Assert
        Assert.That(resultado, Is.EqualTo(4));
    }
}
