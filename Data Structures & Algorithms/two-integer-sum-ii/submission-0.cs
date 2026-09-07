public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int sum = 0;
        int left = 0;
        int right = numbers.Length - 1;
        while (left < right) {
            sum = numbers[left] + numbers[right];
            if (sum == target)
                break;
            if (sum < target)
                left++;
            else
                right--;
        }
        return new int[] { left + 1, right + 1 };
    }
}
