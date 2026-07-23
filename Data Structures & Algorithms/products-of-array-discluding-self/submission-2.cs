public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var productNumber = 0;
        var zeroCount = 0;

        foreach (var num in nums)
        {
            if (num == 0)
            {
                zeroCount++;
                continue;
            }

            if (productNumber == 0)
            {
                productNumber = 1 * num;
            }
            else
            {
                productNumber *= num;
            }
        }

        var productNums = new int[nums.Length];
        if (zeroCount > 1)
        {
            return productNums;
        }
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                productNums[i] = productNumber;
                continue;
            }
            
            if (zeroCount > 0)
            {
                productNums[i] = 0;
            }
            else
            {
                productNums[i] = productNumber / nums[i];
            }
            
        }

        return productNums;
    }
}
