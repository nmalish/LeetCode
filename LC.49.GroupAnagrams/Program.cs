// See https://aka.ms/new-console-template for more information
string[] data = new[] { "eat", "tea", "abs" };




SortedSet<char> first = new();
SortedSet<char> second = new();
first.Add('a');
first.Add('b');
second.Add('a');
bool val = first.SetEquals(second);
Console.WriteLine(val);

Console.ReadLine();


public static class Solution
{
    public static IList<IList<string>> GroupAnagrams(string[] data)
    {
        List<HashSet<char>> collections = new List<HashSet<char>>();
        foreach (string s in data)
        {
            SortedSet<char> chars = new();
            for (int i = 0; i < s.Length; ++i)
            {
                chars.Add(s[i]);
            }
        }
        
        return null;
    }
}