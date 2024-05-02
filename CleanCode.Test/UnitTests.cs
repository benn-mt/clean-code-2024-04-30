namespace CleanCode.Test;

public class UnitTests
{
    [Test]
    public void CanCalculateAmountsInOtherUnits()
    {
        var unit1 = new Unit();
        var unit2 = new Unit(3, unit1);
        Assert.AreEqual(6, unit1.AmountInThisUnit(2, unit2));
        Assert.AreEqual(1.0/3.0, unit2.AmountInThisUnit(1, unit1));
    }
}