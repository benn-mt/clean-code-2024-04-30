using CleanCode;

public static class Volumes{
    public static readonly Unit TEASPOON = new Unit();
    public static readonly Unit TABLESPOON = new Unit(3, TEASPOON);
    public static readonly Unit OUNCE = new Unit(2, TABLESPOON);
    public static readonly Unit CUP = new Unit(8, OUNCE);
    public static readonly Unit PINT = new Unit(2, CUP);
    public static readonly Unit QUART = new Unit(2, PINT);
    public static readonly Unit GALLON = new Unit(4, QUART);
}

public static class DoubleExtensions
{
    public static Quantity teaspoons(this double amount)
    {
        return new Quantity(amount, Volumes.TEASPOON);
    }

    public static Quantity tablespoons(this double amount)
    {
        return new Quantity(amount, Volumes.TABLESPOON);
    }

    public static Quantity ounces(this double amount)
    {
        return new Quantity(amount, Volumes.OUNCE);
    }

    public static Quantity cups(this double amount)
    {
        return new Quantity(amount, Volumes.CUP);
    }

    public static Quantity pints(this double amount)
    {
        return new Quantity(amount, Volumes.PINT);
    }

    public static Quantity quarts(this double amount)
    {
        return new Quantity(amount, Volumes.QUART);
    }

    public static Quantity gallons(this double amount)
    {
        return new Quantity(amount, Volumes.GALLON);
    }
}