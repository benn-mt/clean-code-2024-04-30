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


    [Test]
    public void CanBeCombinedThroughAnd()
    {
        Assert.That(new Chance(0.5).And(new Chance(0.5)), Is.EqualTo(new Chance(0.25)));
        Assert.That(new Chance(0.3).And(new Chance(0.5)), Is.EqualTo(new Chance(0.15)));
        Assert.That(new Chance(0.4).And(new Chance(0.4)), Is.EqualTo(new Chance(0.16)));
        Assert.That(new Chance(0.4).And(new Chance(0.4).And(new Chance(0.4))), Is.EqualTo(new Chance(0.064)));
    }
}