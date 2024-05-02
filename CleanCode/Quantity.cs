namespace CleanCode
{
    public class Quantity
    {
        private double _amount;
        private Unit _unit;

        public Quantity(double amount, Unit unit)
        {
            _amount = amount;
            _unit = unit;
        }

        public Quantity Add(Quantity other)
        {
            if (!_unit.IsCompatibleWith(other._unit))
            {
                throw new ArgumentException("Units are incompatible for addition");
            }
            return new Quantity(_amount + _unit.AmountInThisUnit(other._amount, other._unit), _unit);
        }

        public bool Equals(Quantity other)
        {
            return _unit.IsCompatibleWith(other._unit) &&
                   _amount == _unit.AmountInThisUnit(other._amount, other._unit);
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Quantity)
            {
                return false;
            }
            return Equals((Quantity)obj);
        }

        public override string ToString()
        {
            return _amount.ToString() + " " + _unit.ToString();
        }
    }
}