namespace KataChallangeTests
{
    public class KataChalangeTests
    {
        [Fact]
        public void GivenLetterAShouldGenerateSmallestDiamonA()
        {
            const string letter = "A";

            Assert.Equal("A", Diamond.Generate(letter));
        }


        [Fact]
        public void GivenLetterBShouldGenerateDiamondWithB()
        {
            const string letter = "B";

            Assert.Equal(" A\n" +
                         "B B\n" +
                         " A", Diamond.Generate(letter));
        }
    }
}