
// Console.WriteLine(solution.RomanToInt("MCMXCIV"));

public partial class Solution
{
    public int RomanToInt(string s)
    {
        var result = 0;

        for(int i = 0; i < s.Length - 1; i++)
        {
            if(RomanDigits(s[i]) < RomanDigits(s[i + 1]))
                result -= RomanDigits(s[i]);
            else 
                result += RomanDigits(s[i]);
        }

        return result + RomanDigits(s[s.Length - 1]);
    }

#pragma warning disable CS8509
    private int RomanDigits(char c)
    => c switch
    {
        'I' => 1,
        'V' => 5,
        'X' => 10,
        'L' => 50,
        'C' => 100,
        'D' => 500,
        'M' => 1000
    };
#pragma warning restore CS8509
}