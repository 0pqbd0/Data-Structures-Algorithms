public class Solution {
    public bool IsPalindrome(string s) {
        int l = 0;
        int r = s.Length - 1;
        while (l <= r)
        {
            if ((s[l] < 'A' || s[l] > 'Z') && (s[l] < 'a' || s[l] > 'z') && (s[l] < '0' || s[l] > '9'))
            {
                l++;
            }

            else if ((s[r] < 'A' || s[r] > 'Z') && (s[r] < 'a' || s[r] > 'z') && (s[r] < '0' || s[r] > '9'))
            {
                r--;
            }

            else if (s[l].ToString().ToLower() == s[r].ToString().ToLower())
            {
                l++;
                r--;
            }

            else if (s[l].ToString().ToLower() != s[r].ToString().ToLower())
            {
                return false;
            }
        }
        return true;
    }
}