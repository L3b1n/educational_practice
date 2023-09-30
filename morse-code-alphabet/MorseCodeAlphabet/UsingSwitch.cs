namespace MorseCodeAlphabet
{
    public static class UsingSwitch
    {
        public static byte GetMorseCode(char c)
        {
            switch (c)
            {
                case 'A':
                case 'a':
                    return 0b0011_0001;
                case 'B':
                case 'b':
                    return 0b1111_1110;
                case 'C':
                case 'c':
                    return 0b1111_1010;
                case 'D':
                case 'd':
                    return 0b0111_0110;
                case 'E':
                case 'e':
                    return 0b0001_0001;
                case 'F':
                case 'f':
                    return 0b1111_1011;
                case 'G':
                case 'g':
                    return 0b0111_0100;
                case 'H':
                case 'h':
                    return 0b1111_1111;
                case 'I':
                case 'i':
                    return 0b0011_0011;
                case 'J':
                case 'j':
                    return 0b1111_0001;
                case 'K':
                case 'k':
                    return 0b0111_0010;
                case 'L':
                case 'l':
                    return 0b1111_1101;
                case 'M':
                case 'm':
                    return 0b0011_0000;
                case 'N':
                case 'n':
                    return 0b0011_0010;
                case 'O':
                case 'o':
                    return 0b0111_0000;
                case 'P':
                case 'p':
                    return 0b1111_1001;
                case 'Q':
                case 'q':
                    return 0b1111_0100;
                case 'R':
                case 'r':
                    return 0b0111_0101;
                case 'S':
                case 's':
                    return 0b0111_0111;
                case 'T':
                case 't':
                    return 0b0001_0000;
                case 'U':
                case 'u':
                    return 0b0111_0011;
                case 'V':
                case 'v':
                    return 0b1111_0111;
                case 'W':
                case 'w':
                    return 0b0111_0001;
                case 'X':
                case 'x':
                    return 0b1111_0110;
                case 'Y':
                case 'y':
                    return 0b1111_0010;
                case 'Z':
                case 'z':
                    return 0b1111_1100;

                default:
                    return 0b0000_0000;
            }
        }
    }
}
