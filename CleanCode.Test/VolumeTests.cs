namespace CleanCode.Test;

public class VolumeTests{
    [Test]
    public void KnownUnitConverstions_ExtensionMethods(){
        Assert.That(1.0.tablespoons(), Is.EqualTo(3.0.teaspoons()));
        Assert.That(2.0.tablespoons(), Is.EqualTo(1.0.ounces()));
        Assert.That(8.0.ounces(), Is.EqualTo(1.0.cups()));
        Assert.That(2.0.cups(), Is.EqualTo(1.0.pints()));
        Assert.That(2.0.pints(), Is.EqualTo(1.0.quarts()));
        Assert.That(4.0.quarts(), Is.EqualTo(1.0.gallons()));
    }

    [Test]
    public void KnownUnitConverstions(){
        Assert.That(VolumeUnit.TABLESPOON.S(1), Is.EqualTo(VolumeUnit.TEASPOON.S(3.0)));
        Assert.That(VolumeUnit.TABLESPOON.S(2), Is.EqualTo(VolumeUnit.OUNCE.S(1.0)));
        Assert.That(VolumeUnit.OUNCE.S(8), Is.EqualTo(VolumeUnit.CUP.S(1.0)));
        Assert.That(VolumeUnit.CUP.S(2), Is.EqualTo(VolumeUnit.PINT.S(1.0)));
        Assert.That(VolumeUnit.PINT.S(2), Is.EqualTo(VolumeUnit.QUART.S(1.0)));
        Assert.That(VolumeUnit.QUART.S(4), Is.EqualTo(VolumeUnit.GALLON.S(1.0)));
    }
}