namespace CodeQuest.SlidingWindow
{
    public class AvgSubArrays
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            int maxSum = nums.Take(k).Sum();
            int sum = maxSum;
            for (int i = k ; i < k ; i++)
            {
                maxSum = maxSum + nums[i] - nums[i - k];
                if (maxSum < sum)
                    maxSum = sum;
            }
            return ( double )maxSum / k;
        }
    }
}
