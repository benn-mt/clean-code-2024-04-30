namespace CleanCode.Test;

public class LengthTests{
    [Test]
    public void KnownUnitConverstions_ExtensionMethods(){
        Assert.AreEqual(LengthUnit.INCH.S(12), LengthUnit.FOOT.S(1));
        Assert.AreEqual(LengthUnit.FOOT.S(3), LengthUnit.YARD.S(1));
        Assert.AreEqual(LengthUnit.YARD.S(220), LengthUnit.FURLONG.S(1));
        Assert.AreEqual(LengthUnit.FURLONG.S(8), LengthUnit.MILE.S(1));
    }

    [Test]
    public void CanBeAddedTogether(){
        Assert.That(LengthUnit.INCH.S(3).Add(LengthUnit.INCH.S(9)), Is.EqualTo(LengthUnit.FOOT.S(1)));
        Assert.That(LengthUnit.FOOT.S(3).Add(LengthUnit.YARD.S(2)), Is.EqualTo(LengthUnit.INCH.S(108)));
    }
}