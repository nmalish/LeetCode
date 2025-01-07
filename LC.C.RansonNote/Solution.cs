public class Solution {
	public bool CanConstruct(string ransomNote, string magazine) {
		var dict = new Dictionary<char, int> ();

		for(int i = 0; i < magazine.Length; i++) {
			if(!dict.TryAdd(magazine[i], 1)) {
				dict[magazine[i]] += 1;
			}
		}

		for(int i = 0; i < ransomNote.Length; i++) {
			if(dict.TryGetValue(ransomNote[i], out var value)) {
				if(value == 0) {
					return false;
				}
				dict[ransomNote[i]] -= 1;

			} else {
				return false;
			}
		}

		return true;
	}
}
