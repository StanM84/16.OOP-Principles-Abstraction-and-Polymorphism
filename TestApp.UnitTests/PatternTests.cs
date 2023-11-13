using NUnit.Framework;

namespace TestApp.UnitTests;

public class PatternTests
{
    [TestCase("stanislav", 2 , "sTaNiSlAvsTaNiSlAv")]
    [TestCase("stanislav", 3, "sTaNiSlAvsTaNiSlAvsTaNiSlAv")]
    [TestCase("stanislav", 5, "sTaNiSlAvsTaNiSlAvsTaNiSlAvsTaNiSlAvsTaNiSlAv")]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input, 
        int repetitionFactor, string expected)
    {
        // Arrange

        // Act
        string result = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException()
    {
        string input = "";
        int repetitionFactor = 10;

        Assert.That(() => Pattern.GeneratePatternedString(input, repetitionFactor), Throws.ArgumentException);
    }

    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {
        string input = "Stan";
        int repetitionFactor = -10;

        Assert.That(() => Pattern.GeneratePatternedString(input, repetitionFactor), Throws.ArgumentException);
    }

    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {
        string input = "Stan";
        int repetitionFactor = 0;

        Assert.That(() => Pattern.GeneratePatternedString(input, repetitionFactor), Throws.ArgumentException);
    }
}
