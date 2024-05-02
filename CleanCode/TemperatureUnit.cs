namespace CleanCode
{
    public class TemperatureUnit : Unit
    {
        public static readonly Unit CELSIUS = new TemperatureUnit();
        public static readonly Unit FAHRENHEIT = new TemperatureUnit(5.0/9.0, CELSIUS, 32);

        public TemperatureUnit() : base()
        {
        }

        public TemperatureUnit(double ratioToReferenceUnit, Unit referenceUnit, double offset) : base(ratioToReferenceUnit, referenceUnit, offset)
        {
        }
    }
}