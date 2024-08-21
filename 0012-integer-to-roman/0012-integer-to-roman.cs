public class Solution {
    public string IntToRoman(int num) {
        string roman = "";
        int ths = 0;
        int h = 0;
        int t = 0;
        int f = 0;

        f = num % 10;
        num /= 10;
        t = num % 10;
        num /= 10;
        h = num % 10;
        num /= 10;
        ths = num % 10;

        if (ths != 0)
        {
            for (int i = 0; i < ths; ++i)
            {
                roman += "M";
            }
        }

        if (h != 0)
        {
            if (h == 4)
            {
                roman += "CD";
            }

            else if (h == 9)
            {
                roman += "CM";
            }

            // else if (h == 5)
            // {
            //     roman += "D"
            // }

            else if (h < 5)
            {
                for (int i = 0; i < h; ++i)
                {
                    roman += "C";
                }
            }

            else
            {
                h = h - 5;
                roman += "D";
                for (int i = 0; i < h; ++i)
                {
                    roman += "C";
                }
            }
        }

        if (t != 0)
        {
            if (t == 4)
            {
                roman += "XL";
            }

            else if (t == 9)
            {
                roman += "XC";
            }

            // else if (t == 5)
            // {
            //     roman += "L"
            // }

            else if (t < 5)
            {
                for (int i = 0; i < t; ++i)
                {
                    roman += "X";
                }
            }

            else
            {
                t = t - 5;
                roman += "L";
                for (int i = 0; i < t; ++i)
                {
                    roman += "X";
                }
            }
        }

        if (f != 0)
        {
            if (f == 4)
            {
                roman+= "IV";
            }

            else if (f == 9)
            {
                roman += "IX";
            }

            else if (f < 5)
            {
                for (int i = 0; i < f; ++i)
                {
                    roman += "I";
                }
            }

            else
            {
                f = f - 5;
                roman += "V";
                for (int i = 0; i < f; ++i)
                {
                    roman += "I";
                }
            }
        }
        return roman;
    }
}