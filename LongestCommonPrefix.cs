public partial class Solution
{
    public string LongestCommonPrefix(string[] strs) 
    {
        if(strs.Length == 1)
            return strs[0];
        
        var first = strs[0];
        var last = strs[0];

        foreach(var s in strs)
        {
            if(string.Compare(first, s) > 0)
                first = s;
            
            if(string.Compare(last, s) < 0)
                last = s;
        }

        int index = 0;
        foreach(var c in first)
        {
            if(last[index] != c)
                break;
            
            index++;
        }

        return first.Any() ? first.Substring(0, index) : string.Empty;
    }
}