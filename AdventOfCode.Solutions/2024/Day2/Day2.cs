namespace AdventOfCode2024.Solutions._2024.Day2;

public class Day2
{
    public int GetTotalSaveReports(string fileName)
    {
        var lines = FileParser.GetLines(Constants.Years.Year2024,"Day2", fileName);
        var totalSafeReports = 0;
        foreach (var line in lines)
        {
            var report = line.Split(" ").Select(int.Parse).ToList();
            var isValidReport = IsReportValid(report);
            if (isValidReport)
            {
                totalSafeReports++;
            }
        }

        return totalSafeReports;
    }

    public int GetTotalSaveReportsWithTolerance(string fileName)
    {
        var lines = FileParser.GetLines(Constants.Years.Year2024,"Day2", fileName);
        var totalSafeReports = 0;
        foreach (var line in lines)
        {
            var report = line.Split(" ").Select(int.Parse).ToList();
            var isValidReport = IsReportValid(report);
            if (isValidReport)
            {
                totalSafeReports++;
            }

            if (!isValidReport)
            {
                var newReports = report.Select((x, index) =>
                {
                    var currentReport = report.ConvertAll(book => book).ToList();
                    currentReport.RemoveAt(index);
                    return currentReport;
                }).ToList();
                foreach (var newreport in newReports)
                {
                    var isNewReportValid = IsReportValid(newreport);
                    if (isNewReportValid)
                    {
                        totalSafeReports++;
                        break;
                    }
                }
            }

        }

        return totalSafeReports;
    }


    private static bool IsReportValid(List<int> report)
    {
        var newSortedReportIncreased = report.OrderBy(x => x).ToList();
        var newSortedReportDecreased = report.OrderByDescending(x => x).ToList();
        var isIncreased = report.ElementAt(0) < report.ElementAt(1);
        if (isIncreased)
        {
            if (!report.SequenceEqual(newSortedReportIncreased))
            {
                return false;
            }
        }

        if (!isIncreased)
        {
            if (!report.SequenceEqual(newSortedReportDecreased))
            {
                return false;
            }
        }

        var previous = report.ElementAt(0);
        var isInBoundaries = false;
        for (int i = 1; i < report.Count(); i++)
        {
            var currentItem = report.ElementAt(i);
            if (Math.Abs(currentItem - previous) >= 1 &&
                Math.Abs(currentItem - previous) <= 3)
            {
                isInBoundaries = true;
            }
            else
            {
                isInBoundaries = false;
                break;
            }

            previous = currentItem;
        }

        return isInBoundaries;
    }
}

