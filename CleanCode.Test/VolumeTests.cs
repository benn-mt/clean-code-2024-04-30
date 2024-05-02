namespace CleanCode.Test;

public class VolumeTests{
    [Test]
    public void KnownUnitConverstions_ExtensionMethods(){
        Assert.AreEqual(3.0.teaspoons(), 1.0.tablespoons());
        Assert.AreEqual(1.0.ounces(), 2.0.tablespoons());
        Assert.AreEqual(1.0.cups(), 8.0.ounces());
        Assert.AreEqual(1.0.pints(), 2.0.cups());
        Assert.AreEqual(1.0.quarts(), 2.0.pints());
        Assert.AreEqual(1.0.gallons(), 4.0.quarts());
    }

    [Test]
    public void KnownUnitConverstions(){
        Assert.AreEqual(Volumes.TEASPOON.S(3.0), Volumes.TABLESPOON.S(1));
        Assert.AreEqual(Volumes.OUNCE.S(1.0), Volumes.TABLESPOON.S(2));
        Assert.AreEqual(Volumes.CUP.S(1.0), Volumes.OUNCE.S(8));
        Assert.AreEqual(Volumes.PINT.S(1.0), Volumes.CUP.S(2));
        Assert.AreEqual(Volumes.QUART.S(1.0), Volumes.PINT.S(2));
        Assert.AreEqual(Volumes.GALLON.S(1.0), Volumes.QUART.S(4));
    }
}