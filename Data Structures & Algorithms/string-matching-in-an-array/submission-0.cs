public class Solution {
    public List<string> StringMatching(string[] words) {
        var result = new List<string>();
        for (int i = 0; i < words.Length; i++) {
            for (int j = 0; j < words.Length; j++) {
                if (i == j)
                    continue;
                if (words[j].Contains(words[i])) {
                    result.Add(words[i]);
                    break;
                }
            }
        }
        return result;
    }
}