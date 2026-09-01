public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var map= new Dictionary<string,List<string>>();
        foreach(var str in strs)
        {
            char[] chars= str.ToCharArray();
            Array.Sort(chars);
            string key= new string(chars);
            if(!map.ContainsKey(key))
            {
                map[key]= new List<string>();
            }
            map[key].Add(str);
        }
        return map.Values.ToList();
    }
}
