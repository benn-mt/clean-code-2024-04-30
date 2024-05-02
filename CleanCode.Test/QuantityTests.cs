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
    }
}