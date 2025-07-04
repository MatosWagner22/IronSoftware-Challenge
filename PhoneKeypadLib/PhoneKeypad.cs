using System.Text;

namespace PhoneKeypadLib
{
    public static class PhoneKeypad
    {
        static string[] KEYS = {
            "&'(",
            "ABC",
            "DEF",
            "GHI",
            "JKL",
            "MNO",
            "PQRS",
            "TUV",
            "WXYZ",
            " "
        };
        public static string Translate(string input)
        {
            string output = "";

            int i = 0;

            while (i < input.Length && input[i] != '#')
            {
                char currentDigit = input[i];

                if (char.IsDigit(currentDigit))
                {
                    char digit = currentDigit;
                    int e = 0;


                    while (i < input.Length && input[i] == digit)
                    {
                        e++;
                        i++;
                    }

                    int indexKey = (digit == '0') ? 9 : digit - '1';
                    string keyLetter = KEYS[indexKey];

                    char resultLetter = keyLetter[(e - 1) % keyLetter.Length];
                    output += resultLetter;

                }
                else if (currentDigit == '*')
                {
                    if (output.Length > 0)
                    {
                        output = output.Substring(0, output.Length - 1);
                    }
                    i++;
                }
                else {

                    i++;
                }
            }
            return output;
        }
    }
}