// See https://aka.ms/new-console-template for more information

Console.WriteLine(Solution.PivotIndex(new[] { 1, 7, 3, 6, 5, 6 }));

Console.ReadLine();

public static class Solution
{
    public static int PivotIndex(int[] nums)
    {
        int length = nums.Length;
        int sum = 0;
        for (int i = 0; i < length; ++i)
        {
            sum += nums[i];
            int tempSum = 0;
            for (int j = i + 1; j < length; ++j)
            {
                tempSum += nums[j];
            }
            if (tempSum == sum)
            {
                return i;
            }
        }
        return -1;
    }
}