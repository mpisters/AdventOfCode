namespace AdventOfCode2024.Tests._2024.Day1;

public class Day1Test : ITest
{
    [Fact]
    public void ShouldReturnResultExamplePart1()
    {
        var result = Sut().GetTotalDistance("example_input.txt");
        Assert.Equal(11, result);
    }

    [Fact]
    public void ShouldReturnResultPart1()
    {
       var result = Sut().GetTotalDistance("input.txt");
       Assert.Equal(2580760, result);
    }

    [Fact]
    public void ShouldReturnResultExamplePart2()
    {
        var result = Sut().GetTotalSimilarity("example_input.txt");
        Assert.Equal(31, result);
    }
    
    [Fact]
    public void ShouldReturnResultPart2()
    {
        var result = Sut().GetTotalSimilarity("input.txt");
        Assert.Equal(25358365, result);
    }

    private Solutions._2024.Day1.Day1 Sut() => new Solutions._2024.Day1.Day1();
}