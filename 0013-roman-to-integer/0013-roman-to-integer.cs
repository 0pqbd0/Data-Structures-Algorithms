public class Solution {
    public int RomanToInt(string s) {
        int roman = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'M')
            {
                roman += 1000;
            }

             if (s[i] == 'D')
            {
                roman += 500;
            }

             if (s[i] == 'C')
            {
                if (i < s.Length - 1 && s[i + 1] == 'M')
                {
                    roman += 900;
                    i++;
                }

                else if (i < s.Length - 1 && s[i + 1] == 'D')
                {
                    roman += 400;
                    i++;
                }

                else
                {
                    roman += 100;
                }
            }

            if (s[i] == 'L')
            {
                roman += 50;
            }

            if (s[i] == 'X')
            {
                if (i < s.Length - 1 && s[i + 1] == 'C')
                {
                    roman += 90;
                    i++;
                }

                else if (i < s.Length - 1 && s[i + 1] == 'L')
                {
                    roman += 40;
                    i++;
                }

                else
                {
                    roman += 10;
                }
            }

            if (s[i] == 'V')
            {
                roman += 5;
            }

            if (s[i] == 'I')
            {
                if (i < s.Length - 1 && s[i + 1] == 'X')
                {
                    roman += 9;
                    i++;
                }

                else if (i < s.Length - 1 && s[i + 1] == 'V')
                {
                    roman += 4;
                    i++;
                }

                else
                {
                    roman += 1;
                }
            }
        }
        return roman;
    }
}