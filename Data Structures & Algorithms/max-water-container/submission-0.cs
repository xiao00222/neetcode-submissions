public class Solution {
    public int MaxArea(int[] heights) {
        int result=0;
        int left=0,right=heights.Length-1;
        int area;
        while(left<right)
        {
            area=(Math.Min(heights[left],heights[right])*(right-left));
            result=Math.Max(area,result);
            if(heights[left]<=heights[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return result;
    }
}
