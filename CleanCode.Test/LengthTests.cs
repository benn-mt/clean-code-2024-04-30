namespace CleanCode.Test;

public class LengthTests{
    [Test]
    public void KnownUnitConverstions_ExtensionMethods(){
        Assert.That(LengthUnit.FOOT.S(1), Is.EqualTo(LengthUnit.INCH.S(12)));
        Assert.That(LengthUnit.YARD.S(1), Is.EqualTo(LengthUnit.FOOT.S(3)));
        Assert.That(LengthUnit.FURLONG.S(1), Is.EqualTo(LengthUnit.YARD.S(220)));
        Assert.That(LengthUnit.MILE.S(1), Is.EqualTo(LengthUnit.FURLONG.S(8)));
    }

    [Test]
    public void CanBeAddedTogether(){
        Assert.That(LengthUnit.INCH.S(3).Add(LengthUnit.INCH.S(9)), Is.EqualTo(LengthUnit.FOOT.S(1)));
        Assert.That(LengthUnit.FOOT.S(3).Add(LengthUnit.YARD.S(2)), Is.EqualTo(LengthUnit.INCH.S(108)));
    }
}