namespace CleanCode.Test;

public class LengthTests{
    [Test]
    public void KnownUnitConverstions_ExtensionMethods(){
        Assert.AreEqual(Lengths.INCH.S(12.0), Lengths.FOOT.S(1));
    }
}