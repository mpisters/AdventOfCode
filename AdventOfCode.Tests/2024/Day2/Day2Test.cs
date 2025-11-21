namespace AdventOfCode2024.Tests._2024.Day2;

public class Day2Test : ITest
{
    [Fact]
    public void ShouldReturnResultExamplePart1()
    {
        var result = Sut().GetTotalSaveReports("input_example.txt");
        Assert.Equal(2, result);
    }

    [Fact]
    public void ShouldReturnResultPart1()
    {
        var result = Sut().GetTotalSaveReports("input.txt");
        Assert.Equal(663, result);
    }
    [Fact]
    public void ShouldReturnResultExamplePart2()
    {
        var result = Sut().GetTotalSaveReportsWithTolerance("input_example.txt");
        Assert.Equal(4, result);
    }

    [Fact]
    public void ShouldReturnResultPart2()
    {
        var result = Sut().GetTotalSaveReportsWithTolerance("input.txt");
        Assert.Equal(692, result);
    }

    private Solutions._2024.Day2.Day2 Sut() => new Solutions._2024.Day2.Day2();
}