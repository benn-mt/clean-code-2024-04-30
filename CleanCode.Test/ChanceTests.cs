namespace CleanCode.Test;

public class ChanceTests
{
    [Test]
    public void CanBeComparedForEquality()
    {
        Assert.That(new Chance(0.5).Equals(new Chance(0.5)));
        Assert.That(new Chance(1.0).Equals(new Chance(0.0)), Is.False);
        Assert.That(new Chance(1.0).Equals(new object()), Is.False);
    }
}