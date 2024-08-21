public class Solution {
    public int LengthOfLastWord(string s) {
        int r = s.Length - 1;
        int counter = 0;
        while (s[r] == ' ')
        {
            r--;
        }

        while (r >= 0 && s[r] != ' ')
        {
            counter++;
            r--;
        } 
        return counter;
    }
}