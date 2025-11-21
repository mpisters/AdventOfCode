namespace AdventOfCode2024.Solutions._2024.Day5;

public class Day5
{
    public int GetUpdates()
    {
        var blockOfLines = FileParser.GetBlockOfLines(Constants.Years.Year2024, "Day5", "input.txt");
        var updateRules = blockOfLines.First().Split("\n").Select(x =>
        {
            var rule = x.Split('|');
            return new Tuple<int, int>(int.Parse(rule[0]), int.Parse(rule[1]));
        }).ToList();
        var linesToCheck = blockOfLines.Last().Split("\n").Select(x =>
        {
            var items = x.Split(",");
            return items.Select(int.Parse).ToList();
        }).ToList();
        var updatedItemList = new List<List<int>>();
        for (var j = 0; j < linesToCheck.Count; j++){
            var itemsToCheck = new List<int>(linesToCheck[j]);
            for (var i = 0; i < itemsToCheck.Count; i++)
            {
                var firstItem = itemsToCheck[i];
                var updateRulesForItem = updateRules.Where(x => x.Item1 == firstItem).ToList();
                if (!updateRulesForItem.Any()) continue;
                var indexOfItems = updateRulesForItem.Select(x => itemsToCheck.IndexOf(x.Item2)).Where(y => y >= 0).OrderDescending().ToList();
                if (!indexOfItems.Any())
                {
                    continue;
                }
  
                foreach (var index in indexOfItems)
                {
                    if (index < i )
                    {
                        var newList = Swap(itemsToCheck, i, index);
                        itemsToCheck = newList;
                    }
                    Console.WriteLine($"{string.Join(",", itemsToCheck)} - {string.Join(",", linesToCheck[i])}");

                }
             
            }
            updatedItemList.Add(itemsToCheck);
        }

        var total = 0;
        for (int i = 0; i < updatedItemList.Count; i++)
        {
            var updatedList = updatedItemList[i];
            if (updatedList.SequenceEqual(linesToCheck[i]))
            {
                continue;
            }
            var middleItem = (updatedList.Count - 1) / 2;
            var item = linesToCheck[i][middleItem];
            total += item;
        }
        return total;
    }
    
    private static List<int> Swap(List<int> list, int indexA, int indexB)
    {
        int tmp = list[indexA];
        list[indexA] = list[indexB];
        list[indexB] = tmp;
        return list;
    }
}