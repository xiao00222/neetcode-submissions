public class Solution {
    public int CountSeniors(string[] details) {
        int count = 0;
        for (int i = 0; i < details.Length; i++)
        {
            int age = int.Parse(details[i].Substring(11, 2));
            if (age > 60)
                count++;
        }
        return count;
    }
}