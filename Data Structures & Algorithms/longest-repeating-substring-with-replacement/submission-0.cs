public class Solution {
    public int CharacterReplacement(string s, int k) {
        var dict=new Dictionary<char,int>();
        int result=0;
        int left=0;
        for(int right=0;right<s.Length; right++)
        {
            if(dict.ContainsKey(s[right]))
            {
                dict[s[right]]+=1;
            }
            else{
                dict.Add(s[right],1);
            }
            //check if current window - most freq char exceeds the k limit 
            while((right-left+1)-(dict.Values.Max())>k)
            {
                dict[s[left]]-=1;//decrement the pointer
                left++;//move the pointer
            }
            result=Math.Max(result,right-left+1);
        }
        return result;
    }
}
