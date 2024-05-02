

using CleanCode;

public class Unit{

    private readonly double _ratioToBaseUnit;
    private readonly Unit _baseUnit;
    private readonly double _offset;

    public Unit()
    {
        this._ratioToBaseUnit = 1;
        this._baseUnit = this;
        this._offset = 0;
    }

    public Unit(double ratioToReferenceUnit, Unit referenceUnit) : this(ratioToReferenceUnit, referenceUnit, 0)
    {
    }

    public Unit(double ratioToReferenceUnit, Unit referenceUnit, double offset)
    {
        this._ratioToBaseUnit = ratioToReferenceUnit * referenceUnit._ratioToBaseUnit;
        this._baseUnit = referenceUnit._baseUnit;
        this._offset = offset;
    }

    public double AmountInThisUnit(double otherAmount, Unit otherUnit)
    {
        return (otherAmount - otherUnit._offset) * otherUnit._ratioToBaseUnit / this._ratioToBaseUnit + this._offset;
    }

    public bool IsCompatibleWith(Unit other)
    {
        return this._baseUnit == other._baseUnit;
    }

    public Quantity S(double amount){
        return new Quantity(amount, this);
    }
}