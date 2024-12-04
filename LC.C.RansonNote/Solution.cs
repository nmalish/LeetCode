public class Solution {
	public bool CanConstruct(string ransomNote, string magazine) {
		var dict = new Dictionary<char, int> ();
		var dictMagazine = new Dictionary<char, int>();


		for(int i = 0; i < ransomNote.Length; i++) {
			if(!dict.TryAdd(ransomNote[i], 1)) {
				dict[ransomNote[i]] += 1;
			}
		}
		
		for(int i = 0; i < magazine.Length; i++) {
			if(!dictMagazine.TryAdd(magazine[i], 1)) {
				dictMagazine[magazine[i]] += 1;
			}
		}


		foreach(var item in dict) {
			if(dictMagazine.TryGetValue(item.Key, out var value)) {
				if (value < item.Value) {
					return false;
				}
			} else {
				return false;
			}
		}

		return true;
	}
}
