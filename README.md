//Tests to have tdd process complete

 [Fact]
 public void GivenLetterBShouldGetPaddingLeft()
 {
     Assert.Equal((0, 1), Diamond.GetPadding('B', 'B'));
 }

 [Fact]
 public void GivenLetterBShouldGetExpectedLineForCharacter()
 {
     Assert.Equal(("B B\n"), Diamond.GetLineForCharacter('B', 0, 1));
 }

 [Fact]
 public void GivenLetterBShouldGetExpectedHalfOfDiamondPlusMiddle()
 {
     Assert.Equal(new List<string> { " A\n", "B B\n" }, Diamond.GetHalfOfDiamondPlusMiddle('B'));
 }
