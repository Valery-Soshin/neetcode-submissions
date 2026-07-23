public class Solution {
    public int Search(int[] nums, int target) {
        if (nums.Length == 0)
        {
            return -1;
        }

        if (nums[0] > target)
        {
            return -1;
        }

        var left = 0;
        var right = nums.Length - 1;

        while (left <= right)
        {
            var middle = left + (right - left) / 2;

            if (nums[middle] == target)
            {
                return middle;
            }
            
            if (nums[middle] < target)
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }
        }

        return -1;
    }
}
