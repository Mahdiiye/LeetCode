public class RunningSumof1dArray
{
    public int[] RunningSum(int[] nums)
    {
        int sum = 0;
        int[] runningSum = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            sum = sum+ nums[i];
            runningSum[i] = sum;
        }
        return runningSum;
    }
}