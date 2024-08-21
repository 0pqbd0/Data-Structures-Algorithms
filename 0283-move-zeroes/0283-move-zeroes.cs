public class Solution {
    public void MoveZeroes(int[] nums) 
    {
        int indNull = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[indNull] == 0 && nums[i] != 0)
            {
                (nums[indNull], nums[i]) = (nums[i], nums[indNull]);
                indNull++;
            }

            else if (nums[indNull] == 0 && nums[i] == 0)
            {
                continue;
            }

            else if (nums[indNull] != 0 && nums[i] == 0)
            {
                indNull = i;
            }
        }    
    }
}