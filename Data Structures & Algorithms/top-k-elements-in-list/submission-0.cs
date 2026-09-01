public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dict = new Dictionary<int,int>();
        foreach (var num in nums)
        {
            if(!dict.ContainsKey(num))
            {
                dict[num]=0;
               
            }
             dict[num]++;
        }
        var buckets= new List<int>[nums.Length+1];
        foreach(var pair in dict)
        {
            int num = pair.Key;
            int freq= pair.Value;
            if(buckets[freq]==null)
            buckets[freq]=new List<int>();
            buckets[freq].Add(num);
        }
        var result= new List<int>();
        for(int freq=buckets.Length-1; freq>=1 && result.Count<k; freq--)
        {
            if(buckets[freq]!=null)
            {
                foreach(var num in buckets[freq])
                {
                    result.Add(num);
                    if(result.Count==k)
                    break;
                }
            }
        }
        return result.ToArray();
        
    }
}
