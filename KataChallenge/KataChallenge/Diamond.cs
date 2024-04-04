using System.Text;
using System.Text.RegularExpressions;

namespace KataChallangeTests
{
    public static class Diamond
    {
        private static char STARTING_LETTER = 'A';

        public static string Generate(char letter)
        {

            if (!Regex.IsMatch(letter.ToString(), @"^[A-Z]+$"))
            {
                throw new ArgumentException("Please provide only letters");
            }

            if (letter == STARTING_LETTER)
            {
                return STARTING_LETTER.ToString();
            }

            var upperHalfDiamondWithMiddle = GetHalfOfDiamondPlusMiddle(letter);

            return GenerateFullDiamond(upperHalfDiamondWithMiddle);
        }

        private static string GetLineForCharacter(char v, int paddingLeft, int paddingMiddle)
        {
            var line = string.Empty.PadLeft(paddingLeft) + v.ToString();
            line += string.Empty.PadLeft(paddingMiddle) + v.ToString() + "\n";
            return line;
        }

        private static List<string> GetHalfOfDiamondPlusMiddle(char letter)
        {
            List<string> lines = new List<string>();

            for (var i = STARTING_LETTER; i < letter + 1; i++)
            {
                var padding = GetPadding(i, letter);

                if (i == STARTING_LETTER)
                {
                    lines.Add(string.Empty.PadLeft(padding.Item1) + STARTING_LETTER + "\n");
                }
                else
                {
                    lines.Add(GetLineForCharacter(Convert.ToChar(i), padding.Item1, padding.Item2));
                }
            }

            return lines;
        }

        private static string GenerateFullDiamond(List<string> upperHalfDiamondWithMiddle)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var c in upperHalfDiamondWithMiddle)
            {
                sb.Append(c);
            }

            upperHalfDiamondWithMiddle.Reverse();

            foreach (var c in upperHalfDiamondWithMiddle.Skip(1))
            {
                sb.Append(c);
            }

            return sb.ToString();
        }


        private static (int, int) GetPadding(char i, char letter)
        {
            var paddingLeft = 0;
            var paddingMiddle = 0;
            if (i != letter)
            {
                paddingLeft = letter - i;
            }
            if (i != STARTING_LETTER)
            {
                paddingMiddle = ((i - STARTING_LETTER) * 2) - 1;
            }

            return (paddingLeft, paddingMiddle);
        }
    }
}