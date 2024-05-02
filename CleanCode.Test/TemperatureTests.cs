using NUnit.Framework.Constraints;

namespace CleanCode.Test;

public class TemperatureTests
{
    [Test]
    public void CanBeComparedForEquality()
    {
        Assert.That(TemperatureUnit.CELSIUS.S(100), Is.EqualTo(TemperatureUnit.CELSIUS.S(100)));
    }

    [Test]
    public void KnownUnitConverstions_ExtensionMethods(){
        Assert.That(TemperatureUnit.CELSIUS.S(0), Is.EqualTo(TemperatureUnit.FAHRENHEIT.S(32)));
        Assert.That(TemperatureUnit.CELSIUS.S(100), Is.EqualTo(TemperatureUnit.FAHRENHEIT.S(212)));
        Assert.That(TemperatureUnit.CELSIUS.S(10), Is.EqualTo(TemperatureUnit.FAHRENHEIT.S(50)));
        Assert.That(TemperatureUnit.CELSIUS.S(-40), Is.EqualTo(TemperatureUnit.FAHRENHEIT.S(-40)));

        Assert.That(TemperatureUnit.FAHRENHEIT.S(32), Is.EqualTo(TemperatureUnit.CELSIUS.S(0)));
        Assert.That(TemperatureUnit.FAHRENHEIT.S(212), Is.EqualTo(TemperatureUnit.CELSIUS.S(100)));
        Assert.That(TemperatureUnit.FAHRENHEIT.S(50), Is.EqualTo(TemperatureUnit.CELSIUS.S(10)));
        Assert.That(TemperatureUnit.FAHRENHEIT.S(-40), Is.EqualTo(TemperatureUnit.CELSIUS.S(-40)));
    }
}