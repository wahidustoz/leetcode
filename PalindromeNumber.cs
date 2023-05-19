// var solution = new Solution();
// Console.WriteLine(solution.IsPalindrome(int.Parse(Console.ReadLine())));

public partial class Solution
{
    public bool IsPalindrome(int x)
    {
        if(x < 0) return false;
        if(x < 10) return true;
        if(x % 10 == 0) return false;

        var reverse = 0;

        while(x != 0)
        {
            if(reverse == x || reverse == x / 10)
                return true;
            
            reverse = reverse * 10 + x % 10;
            x /= 10;
        }

        return false;
    }
}