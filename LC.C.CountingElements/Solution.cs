
public class Solution
{
    public int CountElements(int[] arr)
    {
        HashSet<int> set = new();
        int count = default;

        for (int i = 0; i < arr.Length; i++)
        {
            set.Add(arr[i]);
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (set.TryGetValue(arr[i] + 1, out int value))
            {
                count++;
            }
        }
        return count;
    }
}
