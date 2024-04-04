namespace KataChallangeTests
{
    public class KataChalangeTests
    {
        [Fact]
        public void GivenLetterAShouldGenerateSmallestDiamonA()
        {
            const string letter = "A";

            Assert.Equal("A", Diamond.Generate('A'));
        }


        [Fact]
        public void GivenLetterBShouldGenerateDiamondWithB()
        {
            const string letter = "B";

            Assert.Equal(" A\n" +
                         "B B\n" +
                         " A\n", Diamond.Generate('B'));
        }

        [Fact]
        public void GivenLetterCShouldGenerateDiamondWithC()
        {
            const string letter = "B";

            Assert.Equal("  A\n" +
                         " B B\n" +
                         "C   C\n" +
                         " B B\n" +
                         "  A\n", Diamond.Generate('C'));
        }

        [Fact]
        public void GivenParameterIsNotUpperCaseLetterShouldThrowException()
        {
            const string letter = "B";

            Assert.Throws<ArgumentException>(() => Diamond.Generate('1'));
        }

    }
}