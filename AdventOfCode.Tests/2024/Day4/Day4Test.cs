namespace AdventOfCode2024.Tests._2024.Day4;

public class Day4Test : ITest
{
    [Fact]
    public void ShouldReturnResultExamplePart1()
    {
        var result = Sut().GetTotalXmas("input_example.txt");
        Assert.Equal(18, result);
    }

    [Fact]
    public void ShouldReturnAllDiagnals()
    {
        var result = Sut().GetTotalXmas("input_example2.txt");
        Assert.Equal(4, result);
    }
    
    [Fact]
    public void ShouldReturnAllRightLeft()
    {
        var result = Sut().GetTotalXmas("input_example3.txt");
        Assert.Equal(4, result);
    }
    
    [Fact]
    public void ShouldReturnResultPart1()
    {
        var result = Sut().GetTotalXmas("input.txt");
        Assert.Equal(2551, result);
    }

    [Fact]
    public void ShouldReturnResultExamplePart2()
    {
        var result = Sut().GetTotalMas("input_example4.txt");
        Assert.Equal(9, result);
    }

    [Fact]
    public void ShouldReturnResultPart2()
    {
        var result = Sut().GetTotalMas("input.txt");
        Assert.Equal(1985, result);
    }
    private Solutions._2024.Day4.Day4 Sut() => new Solutions._2024.Day4.Day4();

}