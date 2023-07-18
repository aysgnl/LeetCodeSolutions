namespace LCSolutions.Solutions
{
    public static class RemoveDuplicatesSolution
    {
        public static int RemoveDuplicates(int[] nums)
        {
            int length = 0;
            int countElement = 1;

            for (int itr = 1; itr < nums.Length; itr++)
            {
                if (nums[itr] == nums[itr - 1])
                {
                    if (countElement < 2)
                    {
                        countElement++;
                        length++;
                        nums[length] = nums[itr];
                    }
                }
                else
                {
                    countElement = 1;
                    length++;
                    nums[length] = nums[itr];
                }
            }
            return length + 1;
        }
    }
}
