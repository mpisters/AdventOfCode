namespace AdventOfCode2024.Solutions._2024.Day1;

public class Day1
{
    public int GetTotalDistance(string fileName)
    {
        var (firstArray, secondArray) = GetArrays(fileName);
        var i = 0;
        var total = firstArray.Aggregate(0, (prev, x) =>
        {
            var distance = Math.Abs(x - secondArray[i]);
            i++;
            return prev + distance;
        });
        return total;
    }

    private static (List<int> firstArray, List<int> secondArray) GetArrays(string fileName)
    {
        var lines = FileParser.GetLines(Constants.Years.Year2024,"Day1", fileName);
        var firstArray = new List<int>();
        var secondArray = new List<int>();
        foreach (var line in lines)
        {
            var items = line.Split("  ");
            firstArray.Add(int.Parse(items[0]));
            secondArray.Add(int.Parse(items[1]));
        }

        firstArray.Sort();
        secondArray.Sort();
        return (firstArray, secondArray);
    }

    public int GetTotalSimilarity(string fileName)
    {
        var (firstArray, secondArray) = GetArrays(fileName);
        var occuranceArray = firstArray.Select(item =>
        {
            var total = secondArray.Count(x => x == item);
            return total * item;
        });
        return occuranceArray.Aggregate(0, (prev, x) => prev + x);
    }
}