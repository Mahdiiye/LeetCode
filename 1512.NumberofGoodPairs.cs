public class NumberofGoodPairs
{
    static public void Main(String[] args)
    {

        var solution = new NumberofGoodPairs();
        solution.NumIdenticalPairs(new int[] { 1, 2, 3, 1, 1, 3 });
    }

    public int NumIdenticalPairs(int[] nums)
    {
        var goodPairs = new List<(int, int)>();
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] == nums[j] && i < j)
                {
                    goodPairs.Add((i,j));
                }
            }
        }
        foreach (var i in goodPairs)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine(goodPairs.Count);
        return goodPairs.Count;
    }
}