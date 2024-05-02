

using CleanCode;

public class Unit{

    private readonly double _ratioToBaseUnit;
    private readonly Unit _baseUnit;

    public Unit()
    {
        this._ratioToBaseUnit = 1;
        this._baseUnit = this;
    }

    public Unit(double ratioToReferenceUnit, Unit referenceUnit)
    {
        this._ratioToBaseUnit = ratioToReferenceUnit * referenceUnit._ratioToBaseUnit;
        this._baseUnit = referenceUnit._baseUnit;
    }

    public double AmountInThisUnit(double otherAmount, Unit otherUnit)
    {
        return otherAmount * otherUnit._ratioToBaseUnit / this._ratioToBaseUnit;
    }

    public bool IsCompatibleWith(Unit other)
    {
        return this._baseUnit == other._baseUnit;
    }

    public Quantity S(double amount){
        return new Quantity(amount, this);
    }
}