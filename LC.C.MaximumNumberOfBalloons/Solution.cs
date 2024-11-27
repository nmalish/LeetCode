public class Solution
{
    public int MaxNumberOfBalloons(string text)
    {
        Dictionary<char, int> dict = new();
        const string balloon = "balon";
        int min = int.MaxValue;

        for (int i = 0; i < text.Length; i++)
        {
            if (dict.ContainsKey(text[i]))
            {
                dict[text[i]] += 1;
            }
            else
            {
                dict.Add(text[i], 1);
            }
        }

        for (int i = 0; i < balloon.Length; i++)
        {
            if (dict.TryGetValue(balloon[i], out int value))
            {
                if (balloon[i] == 'l' || balloon[i] == 'o')
                {
                    min = value / 2 < min ? (int)(value / 2) : min;
                }
                else
                {
                    min = value < min ? value : min;
                }
            }
            else
            {
                return 0;
            }
        }
        return min;
    }
}
