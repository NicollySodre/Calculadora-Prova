namespace CalculatorService.Tests;

public class DivisaoTest
{
    private readonly CalculadoraService calc = new CalculadoraService();


    [Fact]
    public void TestarDivisaoComNaN()
    {
        // Arrange
        double a = 2.0;
        double b = double.NaN;

        // Act
        double resultado = calc.Divisao(a, b);

        // Assert
        Assert.True(double.IsNaN(resultado));
    }

    [Fact]
    public void TestarDivNumsPositivos()
    {
        float a = 10;
        float b = 4;

        double resultado = calc.Divisao(a, b);

        Assert.Equal(2.5f, resultado);
    }
}

public class SomaTests
{
    private readonly CalculadoraService calc = new CalculadoraService();

    [Fact]
    public void TestarSomaComMaiorNumero()
    {
        int a = int.MaxValue;
        int b = 1;

        Assert.Throws<OverflowException>(() => calc.Soma(a, b));
    }

    [Fact]
    public void TestarSomaDoisPositivos()
    {
        int a = 2;
        int b = 3;

        int resultado = calc.Soma(a, b);

        Assert.Equal(5, resultado);
    }

    [Fact]
    public void TestarSomaPositivoENegativo()
    {
        int a = 2;
        int b = -3;

        int resultado = calc.Soma(a, b);

        Assert.Equal(-1, resultado);
    }

    [Fact]
    public void TestarSomaDoisNegativos()
    {
        int a = -2;
        int b = -3;

        int resultado = calc.Soma(a, b);

        Assert.Equal(-5, resultado);
    }
}

public class SubtracaoTests
{
    private readonly CalculadoraService calc = new CalculadoraService();

    [Fact]
    public void TestarSubtracaoNumsPositivos()
    {
        int a = 1;
        int b = 1;

        int resultado = calc.Subtracao(a, b);

        Assert.Equal(0, resultado);
    }

    [Fact]
    public void TestarSubtracaoPositivoENegativo()
    {
        int a = 4;
        int b = -4;

        int resultado = calc.Subtracao(a, b);

        Assert.Equal(8, resultado);
    }

    [Fact]
    public void TestarSubtracaoNumsNegativos()
    {
        int a = -3;
        int b = -6;

        int resultado = calc.Subtracao(a, b);

        Assert.Equal(3, resultado);
    }
}

public class MultiplicacaoTests
{
    private readonly CalculadoraService calc = new CalculadoraService();

    [Fact]
    public void TestarMultiNumsPositivos()
    {
        int a = 10;
        int b = 2;

        int resultado = calc.Multiplicacao(a, b);

        Assert.Equal(20, resultado);
    }

    [Fact]
    public void TestarMultiPositivoENegativo()
    {
        int a = 10;
        int b = -6;

        int resultado = calc.Multiplicacao(a, b);

        Assert.Equal(-60, resultado);
    }

    [Fact]
    public void TestarMultiNumsNegativo()
    {
        int a = -10;
        int b = -6;

        int resultado = calc.Multiplicacao(a, b);

        Assert.Equal(60, resultado);
    }
}

public class MediaTests
{
    private readonly CalculadoraService calc = new CalculadoraService();

    [Fact]
    public void TestarMediaNumsPositivos()
    {
        int a = 10;
        int b = 6;

        double resultado = calc.Media(a, b);

        Assert.Equal(8, resultado);
    }

    [Fact]
    public void TestarMediaPositivoENegativo()
    {
        int a = 10;
        int b = 6;

        double resultado = calc.Media(a, b);

        Assert.Equal(8, resultado);
    }

    [Fact]
    public void TestarMediaTresNumerosReais()
    {
        float a = 10;
        float b = 6;
        float c = 0.5f;

        double resultado = calc.Media(a, b, c);

        Assert.Equal(5.5f, resultado);
    }
}