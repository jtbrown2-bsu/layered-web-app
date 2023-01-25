namespace FactorialService.Tests;

public class FactorialTests
{
    [Fact]
    public void TestFactorialZeroIsOne()
    {
        Assert.Equal(1, FactorialService.GetFactorialOf(0));
    }
    
    [Fact]
    public void TestFactorialNegative()
    {
        Assert.Throws<Exception>(() =>
        {
            FactorialService.GetFactorialOf(-1);
        });
    }

    [Fact]
    public void TestNormalFactorial()
    {
        Assert.Equal(720, FactorialService.GetFactorialOf(6));
    } 
}