
public class Solution {
	public bool CheckIfPangram(string sentence) {
		HashSet<char> set = new();

		for (int i = 0; i < sentence.Length; i++) {
			set.Add(sentence[i]);
		}

		if (set.Count == 26) 
			return true;
		return default;
	}
}
