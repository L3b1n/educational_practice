namespace MorseCodeAlphabet
{
    public static class UsingIf
    {
        public static string GetMorseCode(char c)
        {
            if (c == 'A' || c == 'a')
            {
                return ".-";
            }

            if (c == 'B' || c == 'b')
            {
                return "-...";
            }

            if (c == 'C' || c == 'c')
            {
                return "-.-.";
            }

            if (c == 'D' || c == 'd')
            {
                return "-..";
            }

            if (c == 'E' || c == 'e')
            {
                return ".";
            }

            if (c == 'F' || c == 'f')
            {
                return "..-.";
            }

            if (c == 'G' || c == 'g')
            {
                return "--.";
            }

            if (c == 'H' || c == 'h')
            {
                return "....";
            }

            if (c == 'I' || c == 'i')
            {
                return "..";
            }

            if (c == 'J' || c == 'j')
            {
                return ".---";
            }

            if (c == 'K' || c == 'k')
            {
                return "-.-";
            }

            if (c == 'L' || c == 'l')
            {
                return ".-..";
            }

            if (c == 'M' || c == 'm')
            {
                return "--";
            }

            if (c == 'N' || c == 'n')
            {
                return "-.";
            }

            if (c == 'O' || c == 'o')
            {
                return "---";
            }

            if (c == 'P' || c == 'p')
            {
                return ".--.";
            }

            if (c == 'Q' || c == 'q')
            {
                return "--.-";
            }

            if (c == 'R' || c == 'r')
            {
                return ".-.";
            }

            if (c == 'S' || c == 's')
            {
                return "...";
            }

            if (c == 'T' || c == 't')
            {
                return "-";
            }

            if (c == 'U' || c == 'u')
            {
                return "..-";
            }

            if (c == 'V' || c == 'v')
            {
                return "...-";
            }

            if (c == 'W' || c == 'w')
            {
                return ".--";
            }

            if (c == 'X' || c == 'x')
            {
                return "-..-";
            }

            if (c == 'Y' || c == 'y')
            {
                return "-.--";
            }

            if (c == 'Z' || c == 'z')
            {
                return "--..";
            }

            return string.Empty;
        }
    }
}
