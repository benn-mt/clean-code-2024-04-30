namespace CleanCode.Test;

public class LengthTests{
    [Test]
    public void KnownUnitConverstions_ExtensionMethods(){
        Assert.AreEqual(Lengths.INCH.S(12), Lengths.FOOT.S(1));
        Assert.AreEqual(Lengths.FOOT.S(3), Lengths.YARD.S(1));
        Assert.AreEqual(Lengths.YARD.S(220), Lengths.FURLONG.S(1));
        Assert.AreEqual(Lengths.FURLONG.S(8), Lengths.MILE.S(1));
    }

    [Test]
    public void CanBeAddedTogether(){
        Assert.That(Lengths.INCH.S(3).Add(Lengths.INCH.S(9)), Is.EqualTo(Lengths.FOOT.S(1)));
    }
}