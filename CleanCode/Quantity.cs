public class Quantity
{
    private double _amount;
    private Unit _unit;

    public Quantity(double amount, Unit unit)
    {
        _amount = amount;
        _unit = unit;
    }

    public bool Equals(Quantity other){
        return _amount == _unit.AmountInThisUnit(other._amount, other._unit);
    }

    public override bool Equals(object? obj)
    {
        if (obj is not Quantity){
            return false;
        }
        return this.Equals((Quantity)obj);
    }

    public override string ToString()
    {
        return _amount.ToString() + " " + _unit.ToString();
    }
}