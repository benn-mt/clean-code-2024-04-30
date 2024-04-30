namespace CleanCode.Test;

public class ChanceTests
{
    [Test]
    public void CanBeComparedForEquality()
    {
        Assert.That(new Chance(0.5).Equals(new Chance(0.5)));
    }
}