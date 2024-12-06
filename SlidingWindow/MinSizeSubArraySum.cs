namespace CodeQuest.SlidingWindow
{
    public class MinSizeSubArraySum
    {
        //sliding window, BUT the window size is not fixed 2,3,1,2,4,3
        public int MinSubArrayLen(int target, int[] nums)
        {
            int windowStart = 0;
            int windowEnd = 0;
            int sum = 0;
            int minLength = int.MaxValue;

            for (windowEnd = 0 ; windowEnd < nums.Length ; windowEnd++)
            {
                sum = sum + nums[windowEnd];

                while (sum >= target)
                {
                    minLength = Math.Min(minLength, windowEnd - windowStart + 1);
                    sum = sum - nums[windowStart];
                    windowStart++;
                }
            }
            if (minLength == int.MaxValue)
                return 0;

            return minLength;
        }
    }
}
