using Xunit;

public class UnitTest1
{
    [Fact]
    public void GetMessage_ReturnsExpectedMessage()
    {
        // Act
        string result = Program.GetMessage();

        // Assert
        Assert.Equal("Hello from GitHub Actions!", result);
    }
}
