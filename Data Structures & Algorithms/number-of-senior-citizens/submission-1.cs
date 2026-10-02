public class Solution {
    public int CountSeniors(string[] details) {
       int count=details.Count(d=>int.Parse(d.Substring(11,2))>60);
       return count;
    }
}