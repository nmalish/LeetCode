public class Solution
{
    public string[] FindRelativeRanks(int[] score)
    {
        var len = score.Length;
        var result = new string[len];
        var sortedScore = new int[len];
        score.CopyTo(sortedScore, 0);
        Array.Sort(sortedScore);

        for (int i = 0; i < len; i++)
        {
            var index = Array.IndexOf(sortedScore, score[i]);

            string place;
            if (index == len - 1)
            {
                place = "Gold Medal";
            }
            else if (index == len - 2)
            {
                place = "Silver Medal";
            }
            else if (index == len - 3)
            {
                place = "Bronze Medal";
            }
            else
            {
                place = (len - index).ToString();
            }

            result[i] = place;
        }

        return result;
    }
}