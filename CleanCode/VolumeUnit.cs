using CleanCode;

public class VolumeUnit : Unit{
    public static readonly Unit TEASPOON = new VolumeUnit();
    public static readonly Unit TABLESPOON = new VolumeUnit(3, TEASPOON);
    public static readonly Unit OUNCE = new VolumeUnit(2, TABLESPOON);
    public static readonly Unit CUP = new VolumeUnit(8, OUNCE);
    public static readonly Unit PINT = new VolumeUnit(2, CUP);
    public static readonly Unit QUART = new VolumeUnit(2, PINT);
    public static readonly Unit GALLON = new VolumeUnit(4, QUART);

    public VolumeUnit() : base()
    {
    }

    public VolumeUnit(double ratioToReferenceUnit, Unit referenceUnit) : base(ratioToReferenceUnit, referenceUnit)
    {
    }
}

public static class DoubleExtensions
{
    public static Quantity teaspoons(this double amount)
    {
        return new Quantity(amount, VolumeUnit.TEASPOON);
    }

    public static Quantity tablespoons(this double amount)
    {
        return new Quantity(amount, VolumeUnit.TABLESPOON);
    }

    public static Quantity ounces(this double amount)
    {
        return new Quantity(amount, VolumeUnit.OUNCE);
    }

    public static Quantity cups(this double amount)
    {
        return new Quantity(amount, VolumeUnit.CUP);
    }

    public static Quantity pints(this double amount)
    {
        return new Quantity(amount, VolumeUnit.PINT);
    }

    public static Quantity quarts(this double amount)
    {
        return new Quantity(amount, VolumeUnit.QUART);
    }

    public static Quantity gallons(this double amount)
    {
        return new Quantity(amount, VolumeUnit.GALLON);
    }
}