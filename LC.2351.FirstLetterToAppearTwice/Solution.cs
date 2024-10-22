
public class Solution
{
    public char RepeatedCharacter(string s)
    {
        var dic = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (!dic.TryAdd(s[i], default))
            {
                return s[i];
            }
        }

        return default;
    }
}
