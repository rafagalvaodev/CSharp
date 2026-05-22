
using Codigo;

namespace TDD;


public class CalculadoraTDD
{
    private Calculadora _calc = new Calculadora();
    
    [Fact]
    public void SomaERetorna5()
    {
        int valor =_calc.Somar(2,3);

        Assert.Equal(5, valor);
    }

    [Theory]
    [InlineData(10, 2, 5)]
    [InlineData(20, 2, 10)]
    public void TestaDividir(int valor1, int valor2, int resultado )
    {
       

        int resultado_calc =  _calc.Dividir(valor1, valor2);

        Assert.Equal(resultado, resultado_calc);
    }

    
    [Theory]
    [InlineData(10, 2, 20)]
    [InlineData(20, 4, 80)]
    public void TestaMultiplicar(int valor1, int valor2, int resultado )
    {
       

        int resultado_calc =  _calc.Mutiplicar(valor1, valor2);

        Assert.Equal(resultado, resultado_calc);
    }

    [Theory]
    [InlineData(10, 2, 8)]
    [InlineData(20, 2, 18)]
    [InlineData(6, 2, 4)]
    [InlineData(12, 6, 6)]
    public void TestaSubtrair(int valor1, int valor2, int resultado )
    {
       

        int resultado_calc =  _calc.Subtrair(valor1, valor2);

        Assert.Equal(resultado, resultado_calc);
    }

   [Fact]
    public void TestaDivisaoPorZero()
    {
        // Given
        //int resultado = _calc.Dividir()
        // When
    
        // Then
        Assert.Throws<DivideByZeroException> (() => _calc.Dividir(3,0));
    }

    [Fact]
    public void TestaHistorico()
    {

        _calc.Somar(2,5);
        _calc.Subtrair(3, 10);
        _calc.Mutiplicar(4, 5);
        _calc.Dividir(10,5);
        var listaHistorico = _calc.ListaHistorico(); 

        
        Assert.NotEmpty(listaHistorico);
        Assert.Equal(3, listaHistorico.Count);
    }
}