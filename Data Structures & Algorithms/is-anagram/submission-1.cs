public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length)
        return false;
       var counts= new Dictionary<char,int>();
       foreach(char c in s){ 
       if(!counts.ContainsKey(c)) counts[c]=0;
       counts[c]++;
       }
       foreach(char c in t){
        if(!counts.ContainsKey(c)) return false;
        counts[c]--;
       }
       return counts.Values.All(v=>v==0);
      
    }
}
