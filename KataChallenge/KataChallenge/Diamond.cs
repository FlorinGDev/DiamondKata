using System.Text;
using System.Text.RegularExpressions;

namespace KataChallangeTests
{
    public static class Diamond
    {
        private static char STARTING_LETTER = 'A';
        private static char NEW_LINE = '\n';

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

        private static List<string> GetHalfOfDiamondPlusMiddle(char letter)
        {
            List<string> lines = new List<string>();

            for (var i = STARTING_LETTER; i < letter + 1; i++)
            {
                (var paddigLeft,var paddingRight) = GetPadding(i, letter);

                if (i == STARTING_LETTER)
                {
                    lines.Add(string.Empty.PadLeft(paddigLeft) + STARTING_LETTER + NEW_LINE);
                }
                else
                {
                    lines.Add(GetLineForCharacter(Convert.ToChar(i), paddigLeft, paddingRight));
                }
            }

            return lines;
        }

        private static string GenerateFullDiamond(List<string> upperHalfDiamondWithMiddle)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var line in upperHalfDiamondWithMiddle)
            {
                sb.Append(line);
            }

            upperHalfDiamondWithMiddle.Reverse();

            foreach (var line in upperHalfDiamondWithMiddle.Skip(1))
            {
                sb.Append(line);
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

        private static string GetLineForCharacter(char character, int paddingLeft, int paddingMiddle)
        {
            var line = string.Empty.PadLeft(paddingLeft) + character.ToString();
            line += string.Empty.PadLeft(paddingMiddle) + character.ToString() + NEW_LINE;
            return line;
        }
    }
}