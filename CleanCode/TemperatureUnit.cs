namespace CleanCode
{
    public class TemperatureUnit : Unit
    {
        public static readonly Unit CELCIUS = new TemperatureUnit();

        public TemperatureUnit() : base()
        {
        }

        public TemperatureUnit(double ratioToReferenceUnit, Unit referenceUnit) : base(ratioToReferenceUnit, referenceUnit)
        {
        }
    }
}