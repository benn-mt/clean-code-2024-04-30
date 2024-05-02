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
        Assert.AreEqual(VolumeUnit.TEASPOON.S(3.0), VolumeUnit.TABLESPOON.S(1));
        Assert.AreEqual(VolumeUnit.OUNCE.S(1.0), VolumeUnit.TABLESPOON.S(2));
        Assert.AreEqual(VolumeUnit.CUP.S(1.0), VolumeUnit.OUNCE.S(8));
        Assert.AreEqual(VolumeUnit.PINT.S(1.0), VolumeUnit.CUP.S(2));
        Assert.AreEqual(VolumeUnit.QUART.S(1.0), VolumeUnit.PINT.S(2));
        Assert.AreEqual(VolumeUnit.GALLON.S(1.0), VolumeUnit.QUART.S(4));
    }
}