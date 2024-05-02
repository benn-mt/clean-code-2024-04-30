namespace CleanCode.Test;

public class QuantityTests
{
    [Test]
    public void CanBeComparedForEquality()
    {
        Assert.That(new Quantity(1, VolumeUnit.TEASPOON), Is.EqualTo(new Quantity(1, VolumeUnit.TEASPOON)));
        Assert.AreNotEqual(new Quantity(1, VolumeUnit.TEASPOON), new Quantity(2, VolumeUnit.TEASPOON));
        Assert.AreNotEqual(new Quantity(1, VolumeUnit.TEASPOON), new object());
        Assert.AreNotEqual(new Quantity(1, VolumeUnit.TEASPOON), null);
        Assert.AreNotEqual(new Quantity(2, VolumeUnit.TEASPOON), new Quantity(1, VolumeUnit.TEASPOON));
        Assert.That(new Quantity(1, VolumeUnit.TABLESPOON), Is.EqualTo(new Quantity(1, VolumeUnit.TABLESPOON)));
        Assert.AreNotEqual(new Quantity(1, VolumeUnit.TEASPOON), new Quantity(1, VolumeUnit.TABLESPOON));
        Assert.AreNotEqual(new Quantity(1, VolumeUnit.TABLESPOON), new Quantity(1, VolumeUnit.TEASPOON));
        Assert.AreNotEqual(new Quantity(1, VolumeUnit.TEASPOON), new Quantity(1, LengthUnit.INCH));
    }

    [Test]
    public void CanBeAddedTogether(){
        Assert.That(LengthUnit.INCH.S(3).Add(LengthUnit.INCH.S(9)), Is.EqualTo(LengthUnit.FOOT.S(1)));
        Assert.That(LengthUnit.FOOT.S(3).Add(LengthUnit.YARD.S(2)), Is.EqualTo(LengthUnit.INCH.S(108)));
    }

    [Test]
    public void IncompatibleQuantitiesCanNotBeAdded(){
        Assert.Throws<ArgumentException>(() => LengthUnit.INCH.S(1).Add(VolumeUnit.TEASPOON.S(1)));
        Assert.Throws<ArgumentException>(() => VolumeUnit.TEASPOON.S(1).Add(LengthUnit.INCH.S(1)));
    }
}