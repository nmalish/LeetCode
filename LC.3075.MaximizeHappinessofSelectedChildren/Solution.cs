public class Solution
{
    public long MaximumHappinessSum(int[] happiness, int k)
    {
        long sum = 0;
        Array.Sort(happiness, (x, y) => y.CompareTo(x));

        int i = 0;
        while (i < happiness.Length && happiness[i] - i > 0 && i < k)
        {
            sum += happiness[i] - i;
            i += 1;
        }

        return sum;
    }
}
