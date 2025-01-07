int val = Solution.Maximum69Number(696969);
Console.WriteLine(val);
Console.ReadLine();


public static class Solution
{
    public static int Maximum69Number(int num)
    {
        string s = num.ToString();
        int index = -1;
        int i = 0;
        while (index < 0 && i < s.Length)
        {
            if (s[i] == '6')
            {
                index = i;
            }

            i++;
        }

        if (index >= 0)
        {
            string s1 = s.Remove(index, 1).Insert(index, "9");
            if (int.TryParse(s1, out int result))
            {
                return result;
            }
        }

        return num;
    }

    public static int Maximum69NumberBuildIn(int num)
    {
        string s = num.ToString();
        // s.ReplaseFi 

        return num;
    }
}