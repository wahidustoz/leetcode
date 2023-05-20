public partial class Solution
{
    public bool IsValid(string s) 
    {
        var stack = new Stack<char>();

        foreach(var c in s)
        {
            if("{([".Contains(c))
            {
                stack.Push(c);
                continue;
            }

            if(")}]".Contains(c) && stack.Count() < 1)
                return false;
            
            if(c == ')' && stack.Peek() == '(') stack.Pop();
            else if(c == '}' && stack.Peek() == '{') stack.Pop();
            else if(c == ']' && stack.Peek() == '[') stack.Pop();
            else return false;
        }

        return stack.Count() < 1;
    }
}