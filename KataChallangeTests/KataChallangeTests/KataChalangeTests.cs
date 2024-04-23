using System.Collections.Generic;

namespace KataChallangeTests
{
    public class KataChalangeTests
    {
        [Fact]
        public void GivenLetterAShouldGenerateSmallestDiamonA()
        {
            Assert.Equal("A", Diamond.Generate('A'));
        }


        [Fact]
        public void GivenLetterBShouldGenerateDiamondWithB()
        {
            Assert.Equal(" A\n" +
                         "B B\n" +
                         " A\n", Diamond.Generate('B'));
        }

        [Fact]
        public void GivenLetterCShouldGenerateDiamondWithC()
        {
            Assert.Equal("  A\n" +
                         " B B\n" +
                         "C   C\n" +
                         " B B\n" +
                         "  A\n", Diamond.Generate('C'));
        }

        [Fact]
        public void GivenParameterIsNotUpperCaseLetterShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => Diamond.Generate('1'));
        }


        //Tests to have tdd process complete to create other methods
        //[Fact] 
        //public void GivenLetterBShouldGetPaddingLeft()
        //{
        //  Assert.Equal((0, 1), Diamond.GetPadding('B', 'B'));
        //}

        //[Fact]
        //public void GivenLetterBShouldGetExpectedLineForCharacter()
        //{
        //  Assert.Equal(("B B\n"), Diamond.GetLineForCharacter('B', 0, 1));
        //}

        //[Fact]
        //public void GivenLetterBShouldGetExpectedHalfOfDiamondPlusMiddle()
        //{
        //  Assert.Equal(new List { " A\n", "B B\n" }, Diamond.GetHalfOfDiamondPlusMiddle('B'));
        //}
    }
}