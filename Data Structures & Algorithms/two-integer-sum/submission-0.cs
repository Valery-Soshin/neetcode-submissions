public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, int>();

        for(int a = 0; a < nums.Length; a++){
            var difference = target - nums[a];
            if (dict.TryGetValue(difference, out var b)){
                return [b, a];
            }
            else{
                dict[nums[a]] = a;
            }
        }

        return [];
    }
}
