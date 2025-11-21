using System.Text.RegularExpressions;

namespace AdventOfCode2024.Solutions._2024.Day3;

public class Day3
{
    public int GetTotalMultiplied(string fileName)
    {
        var lines = FileParser.GetLines(Constants.Years.Year2024,"Day3", fileName);
        var total = 0;
        foreach (var line in lines)
        {
            // language=regexp
            var regexPattern = @"(mul\(\d+,\d+\))";
            var matches = Regex.Matches(line, regexPattern);
            var list = matches.Cast<Match>().Select(match => match.Value).ToList();

            foreach (var match in list)
            {
                var numbers = match.Replace("mul(", "").Replace(")", "").Split(',').Select(int.Parse).ToList();
                total += numbers[0] * numbers[1];
            }
            

        }

        return total;
    }
    
    public int GetTotalMultipliedWithCommandos(string fileName)
    {
        var lines = FileParser.GetLines(Constants.Years.Year2024,"Day3", fileName);
        var total = 0;
        var isEnabled = true;

        foreach (var line in lines)
        {
            // language=regexp
            var regexPattern = @"(don't\(\)|do\(\)|mul\(\d+,\d+\))";
            var matches = Regex.Matches(line, regexPattern);
            var list = matches.Cast<Match>().Select(match => match.Value).ToList();
            foreach (var match in list)
            {
                if (match.Contains("mul") && isEnabled)
                {
                    var numbers = match.Replace("mul(", "").Replace(")", "").Split(',').Select(int.Parse).ToList();
                    total += numbers[0] * numbers[1];
                }

                if (match.Contains("don"))
                {
                    isEnabled = false;
                }

                if (match.Contains("do("))
                {
                    isEnabled = true;
                }
            }
            

        }

        return total;
    }
}