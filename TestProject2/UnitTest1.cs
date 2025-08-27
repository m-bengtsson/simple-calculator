using Calculator;
namespace TestProject2;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Operations op = new Operations();
        var result = op.Add(2, 2);
        Assert.Equal(4, result);
    }
}
