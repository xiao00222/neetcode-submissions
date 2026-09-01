public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length)
        return false;
        var sSorted= s.OrderBy(c=>c).ToArray();
        var tSorted= t.OrderBy(c=>c).ToArray();
        return sSorted.SequenceEqual(tSorted);
      
    }
}
