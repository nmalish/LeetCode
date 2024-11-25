public class Solution
{
    public int LargestUniqueNumber(int[] nums)
    {
        SortedDictionary<int, int> dict = new();
        int n = nums.Length;

        for (int i = 0; i < n; i++)
        {
            if (!dict.TryAdd(nums[i], 1))
            {
                dict[nums[i]] += 1;
            }
        }

        var last = dict.Last();
        while (last.Value > 1)
        {
            if (dict.Count == 1)
            {
                return -1;
            }
            dict.Remove(last.Key);
            last = dict.Last();
        }
        return last.Key;
    }
}
