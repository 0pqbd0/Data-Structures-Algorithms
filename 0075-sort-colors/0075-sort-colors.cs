public class Solution {
    public void SortColors(int[] nums) 
    {
        int indZero = 0;
        int indTwo = nums.Length - 1;
        for (int i = 0; i <= indTwo;)
        {
            if (i < nums.Length && nums[i] == 2)
            {
                (nums[i], nums[indTwo]) = (nums[indTwo], nums[i]);
                indTwo--;
            }

            if (i < nums.Length && nums[i] == 0)
            {
                if (indZero != i)
                {
                    (nums[i], nums[indZero]) = (nums[indZero], nums[i]);
                    indZero++;
                }

                else 
                {
                    i++;
                    indZero++;
                }
            }

            if (i < nums.Length && nums[i] == 1)
            {
                i++;
            }
        }  
    }
}