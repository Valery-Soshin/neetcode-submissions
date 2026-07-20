public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var left = 0;
        var right = numbers.Length - 1;

        while (left < right)
        {
            var summa = numbers[left] + numbers[right];

            if (summa == target)
            {
                return [left + 1, right + 1];
            }
            else if (summa > target)
            {
                right--;
            }
            else
            {
                left++;
            }
        }

        return [];
    }   
}
