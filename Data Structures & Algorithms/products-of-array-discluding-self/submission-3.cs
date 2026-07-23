public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var prefixNums = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            if (i == 0)
            {
                prefixNums[i] = nums[i];
            }
            else
            {
                prefixNums[i] = prefixNums[i - 1] * nums[i];
            }
        }

        var postfixNums = new int[nums.Length];
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (i == nums.Length - 1)
            {
                postfixNums[i] = nums[i];
            }
            else
            {
                postfixNums[i] = postfixNums[i + 1] * nums[i];
            }
        }

        var output = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            if (i == 0)
            {
                output[i] = postfixNums[i + 1];
            }
            else if (i == nums.Length - 1)
            {
                output[i] = prefixNums[i - 1];
            }
            else
            {
                output[i] = prefixNums[i - 1] * postfixNums[i + 1];
            }
        }

        return output;
    }
}
