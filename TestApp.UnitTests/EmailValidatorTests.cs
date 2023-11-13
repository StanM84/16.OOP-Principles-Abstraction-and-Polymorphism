using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{
    [TestCase("stan@abv.bg")]
    [TestCase("markov84@gmail.com")]
    [TestCase("stanislav+markov84@gmail.com")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }

    
    [TestCase("stan @abv.bg")]
    [TestCase("stan#markov@a_bv.bg")]
    [TestCase("stan/markov@abv.bg")]
    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);
        
        // Assert
        Assert.That(result, Is.False);
    }
}
