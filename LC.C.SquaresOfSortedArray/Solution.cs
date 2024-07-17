public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        var res = new List<int>();

        int len = nums.Length;

        if (len == 0)
        {
            return [];
        }

        int i = 0;
        int j = nums.Length - 1;

        while (i != j)
        {
            int left = nums[i] * nums[i];
            int right = nums[j] * nums[j];


            if (left > right)
            {
                res.Insert(0, left);
                i++;
            }
            else
            {
                res.Insert(0, right);
                j--;
            }
        }

        if (i == j)
        {
            res.Insert(0, nums[i] * nums[i]);
        }

        return res.ToArray();
    }
}