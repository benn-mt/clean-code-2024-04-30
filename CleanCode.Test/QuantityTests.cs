namespace CleanCode.Test;

public class QuantityTests
{
    [Test]
    public void CanBeComparedForEquality()
    {
        Assert.AreEqual(new Quantity(1, Volumes.TEASPOON), new Quantity(1, Volumes.TEASPOON));
        Assert.AreNotEqual(new Quantity(1, Volumes.TEASPOON), new Quantity(2, Volumes.TEASPOON));
        Assert.AreNotEqual(new Quantity(1, Volumes.TEASPOON), new object());
        Assert.AreNotEqual(new Quantity(1, Volumes.TEASPOON), null);
        Assert.AreNotEqual(new Quantity(2, Volumes.TEASPOON), new Quantity(1, Volumes.TEASPOON));
        Assert.AreEqual(new Quantity(1, Volumes.TABLESPOON), new Quantity(1, Volumes.TABLESPOON));
        Assert.AreNotEqual(new Quantity(1, Volumes.TEASPOON), new Quantity(1, Volumes.TABLESPOON));
        Assert.AreNotEqual(new Quantity(1, Volumes.TABLESPOON), new Quantity(1, Volumes.TEASPOON));
        Assert.AreNotEqual(new Quantity(1, Volumes.TEASPOON), new Quantity(1, Lengths.INCH));
    }

    [Test]
    public void CanBeAddedTogether(){
        Assert.That(Lengths.INCH.S(3).Add(Lengths.INCH.S(9)), Is.EqualTo(Lengths.FOOT.S(1)));
        Assert.That(Lengths.FOOT.S(3).Add(Lengths.YARD.S(2)), Is.EqualTo(Lengths.INCH.S(108)));
    }

    [Test]
    public void IncompatibleQuantitiesCanNotBeAdded(){
        Assert.Throws<ArgumentException>(() => Lengths.INCH.S(1).Add(Volumes.TEASPOON.S(1)));
        Assert.Throws<ArgumentException>(() => Volumes.TEASPOON.S(1).Add(Lengths.INCH.S(1)));
    }
}