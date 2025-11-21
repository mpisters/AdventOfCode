namespace AdventOfCode2024;

public static class FileParser
{
    public static string[] GetLines(string year ,string folderName, string fileName)
    {
        var path = Path.Combine(Environment.CurrentDirectory, year, folderName, fileName);
        return File.ReadAllLines(path);
    }

    public static string[] GetBlockOfLines(string year, string folderName, string fileName)
    {
        var path = Path.Combine(Environment.CurrentDirectory, year, folderName, fileName);
        var file = File.ReadAllText(path);
        var inputLines = file.Split(new string[] { "\n\n" },
            StringSplitOptions.RemoveEmptyEntries);
        return inputLines;
    }
}