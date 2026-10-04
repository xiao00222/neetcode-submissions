public class Solution {
    public List<List<int>> Generate(int numRows) {
        var res= new List<List<int>>();
        res.Add(new List<int>{1});
        for(int i=1; i<numRows; i++)
        {
            var prev=res[i-1];
            var row=new List<int>();
            row.Add(1);
            for(int j=1; j<i; j++)
            {
                row.Add(prev[j-1]+prev[j]);
            }
            row.Add(1);
            res.Add(row);
        }
        return res;
    }
}