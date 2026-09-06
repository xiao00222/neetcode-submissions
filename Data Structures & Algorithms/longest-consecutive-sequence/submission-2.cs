public class Solution {
    public int LongestConsecutive(int[] nums) {
        var hashset = new HashSet<int>(nums);
        int longest = 0;
        int length;
        foreach (var num in nums) {
            if (!hashset.Contains(num - 1)) {
                length = 0;
                while (hashset.Contains(num + length)) 
                    length += 1;
                longest = Math.Max(length, longest);
            }

        }
        return longest;
    }
}

