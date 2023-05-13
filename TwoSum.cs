public partial class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        // hashmap

        var hash = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if(hash.ContainsKey(target - nums[i]))
                return new int[] { i, hash[target - nums[i]]};
            else
                hash.TryAdd(nums[i], i);
        }

        return new int[] { };
    }
}