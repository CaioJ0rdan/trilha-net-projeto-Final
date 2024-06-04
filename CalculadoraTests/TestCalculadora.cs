namespace CalculadoraTests;

using Calculadora.Services;
public class TestCalculadora
{

    private Calculadora _calc;
    public TestCalculadora()
    {
        _calc = new Calculadora();
    }

    [Theory]
    [InlineData (2,1,3)]
    [InlineData (6,3,9)]
    [InlineData (10,5,15)]
    public void TestSomar(int a,int b,int res)
    {
        var resAtual = _calc.Somar(a,b);
        
        Assert.Equal(res,resAtual);
    }
    [Theory]
    [InlineData (2,1,1)]
    [InlineData (6,3,3)]
    [InlineData (10,5,5)]
    public void TestSubtrair(int a,int b,int res)
    {
        var resAtual = _calc.Subtrair(a,b);
        
        Assert.Equal(res,resAtual);
    }
    [Theory]
    [InlineData (2,1,2)]
    [InlineData (6,3,18)]
    [InlineData (10,5,50)]
    public void TestMultiplicar(int a,int b,int res)
    {
        var resAtual = _calc.Multiplicar(a,b);
        
        Assert.Equal(res,resAtual);
    }  
    [Theory]
    [InlineData (2,1,2)]
    [InlineData (6,3,2)]
    [InlineData (10,5,2)]
    public void TestDividir(int a,int b,int res)
    {
        var resAtual = _calc.Dividir(a,b);
        
        Assert.Equal(res,resAtual);
    }       
   
}