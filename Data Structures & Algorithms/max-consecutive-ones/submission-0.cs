public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int result=0;
        int count=0;
        foreach(int num in nums)
        {
            if(num==1)
            {
                count++;
                result=Math.Max(result,count);
            }
            else
            count=0;
        }
        return result;
        
    }
}