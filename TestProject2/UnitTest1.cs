using Calculator;
namespace TestProject2;

public class OperationsTests
{
    [Theory]
    [InlineData(2, 3, 5)]
    [InlineData(-1, 1, 0)]
    [InlineData(0, 0, 0)]
    [InlineData(-2, -3, -5)]
    public void Add_ReturnSum(int a, int b, int expected)
    {
        Operations op = new Operations();
        var result = op.Add(a, b);
        Assert.Equal(expected, result);
    }
    [Theory]
    [InlineData(5, 3, 2)]
    [InlineData(1, 1, 0)]
    [InlineData(0, 0, 0)]
    [InlineData(-2, -3, 1)]
    public void Subtract_ReturnDifference(int a, int b, int expected)
    {
        Operations op = new Operations();
        var result = op.Subtract(a, b);
        Assert.Equal(expected, result);
    }
    [Theory]
    [InlineData(2, 3, 6)]
    [InlineData(-1, 1, -1)]
    [InlineData(0, 5, 0)]
    [InlineData(-2, -3, 6)]
    public void Multiply_ReturnProduct(int a, int b, int expected)
    {
        Operations op = new Operations();
        var result = op.Multiply(a, b);
        Assert.Equal(expected, result);
    }
    [Theory]
    [InlineData(6, 3, 2)]
    [InlineData(5, 2, 2.5)]
    [InlineData(-6, -2, 3)]
    [InlineData(-6, 2, -3)]
    public void Divide_ReturnQuotient(int a, int b, double expected)
    {
        Operations op = new Operations();
        var result = op.Divide(a, b);
        Assert.Equal(expected, result);
    }
    [Fact]
    public void Divide_ByZero_ThrowsException()
    {
        Operations op = new Operations();
        Assert.Throws<DivideByZeroException>(() => op.Divide(5, 0));
    }

    [Fact]
    public void TryGetNumbers_ValidInput_ReturnsNumbers()
    {
        Operations op = new Operations();

        // Simulate user input
        var result = op.TryGetNumbers(() => "3,4");
        Assert.Equal(Tuple.Create(3, 4), result);
    }
}
