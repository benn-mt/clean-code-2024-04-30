using NUnit.Framework.Constraints;

namespace CleanCode.Test;

public class TemperatureTests
{
    [Test]
    public void CanBeComparedForEquality()
    {
        Assert.That(TemperatureUnit.CELCIUS.S(100), Is.EqualTo(TemperatureUnit.CELCIUS.S(100)));
    }
}