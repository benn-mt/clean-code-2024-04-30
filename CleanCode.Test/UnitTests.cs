namespace CleanCode.Test;

public class UnitTests
{
    [Test]
    public void CanCalculateAmountsInOtherUnits()
    {
        var unit1 = new Unit();
        var unit2 = new Unit(3, unit1);
        Assert.That(unit1.AmountInThisUnit(2, unit2), Is.EqualTo(6));
        Assert.That(unit2.AmountInThisUnit(1, unit1), Is.EqualTo(1.0 / 3.0));
    }

    [Test]
    public void UnitsCanBeIncompatible(){
        var unit1 = new Unit();
        Assert.That(unit1.IsCompatibleWith(unit1), Is.True);
        var unit2 = new Unit();
        Assert.That(unit1.IsCompatibleWith(unit2), Is.False);
        Assert.That(unit2.IsCompatibleWith(unit1), Is.False);
        var subUnit1 = new Unit(1, unit1);
        Assert.That(subUnit1.IsCompatibleWith(unit1), Is.True);
        Assert.That(unit1.IsCompatibleWith(subUnit1), Is.True);
        var subUnit2 = new Unit(1, subUnit1);
        Assert.That(subUnit2.IsCompatibleWith(unit1), Is.True);
        Assert.That(unit1.IsCompatibleWith(subUnit2), Is.True);
    }
}