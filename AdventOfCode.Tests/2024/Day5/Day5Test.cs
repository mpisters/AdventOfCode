namespace AdventOfCode2024.Tests._2024.Day5;

public class Day5Test : ITest
{
    [Fact]
    public void ShouldReturnResultExamplePart1()
    {
        var result = Sut().GetUpdates();
        Assert.Equal(143, result);
    }

    public void ShouldReturnResultPart1()
    {
        throw new NotImplementedException();
    }

    public void ShouldReturnResultExamplePart2()
    {
        throw new NotImplementedException();
    }

    public void ShouldReturnResultPart2()
    {
        throw new NotImplementedException();
    }

    private Solutions._2024.Day5.Day5 Sut() => new();
}