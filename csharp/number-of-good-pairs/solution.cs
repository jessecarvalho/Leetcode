public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        var counter = 0;
        for (var i = 0; i < nums.Length - 1; i++) {
            for (var j = i + 1; j < nums.Length ; j++) {
                if (nums[i] == nums[j]) {
                    counter += 1;
                }
            }
        }
        return counter;
    }
}