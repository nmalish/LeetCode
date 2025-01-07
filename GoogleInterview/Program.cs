// [1,2,3,9]    sum=8
// [1,2,4,4]    sum=8

Solution solution = new();
bool result = solution.PairOfElementsEqualsToSumExist(new[] { 1, 2, 3, 9 }, 8);
bool result1 = solution.PairOfElementsEqualsToSumExist(new[] { 1, 2, 4, 4 }, 8);

Console.WriteLine(result);
Console.WriteLine(result1);

Solution2 solution2 = new();
bool result2 = solution2.HasPairWithSum(new[] { 1, 2, 3, 9 }, 8);
bool result3 = solution2.HasPairWithSum(new[] { 1, 2, 4, 4 }, 8);

Console.WriteLine(result2);
Console.WriteLine(result3);
Console.ReadLine();

public class Solution
{
    public bool PairOfElementsEqualsToSumExist(int[] data, int sum) // TODO: HasPairWithSum 
    {
        int i = 0;
        int j = data.Length - 1;
        while (i < j)
        {
            int tempSum = data[i] + data[j];
            if (sum == tempSum) return true;
            if (tempSum < sum)
                i++;
            else
                j--;
        }

        return false;
    }
}

public class Solution2
{
    public bool HasPairWithSum(int[] data, int sum)
    {
        HashSet<int> collection = new(); // TODO: complements
        for (int i = 0; i < data.Length; i++)
        {
            int subtraction = sum - data[i];
            if (collection.Contains(subtraction))
                return true;
            collection.Add(subtraction);
        }

        return false;
    }
}