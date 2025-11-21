namespace AdventOfCode2024.Solutions._2024.Day4;

public class Day4
{
    public int GetTotalXmas(string fileName)
    {
        var lines = FileParser.GetLines(Constants.Years.Year2024,"Day4", fileName);
        var matrix = lines.Select(x => x.ToCharArray()).ToList();
        var maxlengthRow = matrix[0].Length;
        var totalRows = matrix.Count;
        var totalXmas = 0;
        var totalCharactersXMas = 4;
        for (var i = 0; i < matrix.Count; i++)
        {
            var line = matrix[i];
            for (var j = 0; j < line.Length; j++)
            {
                var letter = line[j];
                if (letter == 'X')
                {
                    var xMaxPoint = j + totalCharactersXMas;
                    if (xMaxPoint <= maxlengthRow)
                    {
                        // x - to the right
                        Char[] letters = new char[] { line[j], matrix[i][j + 1], matrix[i][j + 2], matrix[i][j + 3] };
                        var word = new string(letters);
                        if (word == "XMAS")
                        {
                            totalXmas++;
                        }
                    }

                    var xMinPoint = j+1 - totalCharactersXMas;
                    if (xMinPoint >= 0)
                    {
                        // x - to the left
                        Char[] letters = new char[] { line[j], matrix[i][j - 1], matrix[i][j - 2], matrix[i][j - 3] };
                        var word = new string(letters);
                        if (word == "XMAS")
                        {
                            totalXmas++;
                        }
                    }

                    var yMaxPoint = i + totalCharactersXMas;
                    if (yMaxPoint <= totalRows)
                    {
                        // x - to the top
                        Char[] letters = new char[] { line[j], matrix[i + 1][j], matrix[i + 2][j], matrix[i + 3][j] };
                        var word = new string(letters);
                        if (word == "XMAS")
                        {
                            totalXmas++;
                        }
                    }

                    var yMinPoint = i+1 - totalCharactersXMas;
                    if (yMinPoint >= 0)
                    {
                        // x - to the bottom
                        Char[] letters = new char[] { line[j], matrix[i - 1][j], matrix[i - 2][j], matrix[i - 3][j] };
                        var word = new string(letters);
                        if (word == "XMAS")
                        {
                            totalXmas++;
                        }
                    }

                    if (xMaxPoint <= maxlengthRow && yMinPoint >= 0)
                    {
                        // x - diagnal right, top
                        Char[] letters = new char[]
                            { line[j], matrix[i - 1][j + 1], matrix[i - 2][j + 2], matrix[i - 3][j + 3] };
                        var word = new string(letters);
                        if (word == "XMAS")
                        {
                            totalXmas++;
                        }
                    }

                    if (xMaxPoint <= maxlengthRow && yMaxPoint <= totalRows)
                    {
                        // x - diagnal right, bottom
                        Char[] letters = new char[]
                            { line[j], matrix[i + 1][j + 1], matrix[i + 2][j + 2], matrix[i + 3][j + 3] };
                        var word = new string(letters);
                        if (word == "XMAS")
                        {
                            totalXmas++;
                        }
                    }

                    if (xMinPoint >= 0 && yMinPoint >= 0)
                    {
                        // x - diagnal left, top
                        Char[] letters = new char[]
                            { line[j], matrix[i - 1][j - 1], matrix[i - 2][j - 2], matrix[i - 3][j - 3] };
                        var word = new string(letters);
                        if (word == "XMAS")
                        {
                            totalXmas++;
                        }
                    }

                    if (xMinPoint >= 0 && yMaxPoint <= totalRows)
                    {
                        // diagnal left, bottom
                        Char[] letters = new char[]
                            { line[j], matrix[i + 1][j - 1], matrix[i + 2][j - 2], matrix[i + 3][j - 3] };
                        var word = new string(letters);
                        if (word == "XMAS")
                        {
                            totalXmas++;
                        }
                    }
                }
            }
        }

        return totalXmas;
    }
    
    public int GetTotalMas(string fileName)
    {
        var lines = FileParser.GetLines(Constants.Years.Year2024,"Day4", fileName);
        var matrix = lines.Select(x => x.ToCharArray()).ToList();
        var totalmas = 0;
        for (var i = 0; i < matrix.Count; i++)
        {
            var line = matrix[i];
            for (var j = 0; j < line.Length; j++)
            {
                var letter = line[j];
                if (letter == 'A')
                {
                    try
                    {
                        var rt = matrix[i + 1][j + 1];
                        var rb = matrix[i - 1][j + 1];
                        var lb = matrix[i - 1][j - 1];
                        var lt = matrix[i + 1][j - 1];
                        if (rt != lb &&
                            rt is 'S' or 'M' &&
                            lb is 'S' or 'M' && 
                            rb is 'S' or 'M' && 
                            lt is 'S' or 'M' &&
                            lt != rb)
                        {
                            totalmas++;
                        }
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
            }
        }

        return totalmas;
    }
}