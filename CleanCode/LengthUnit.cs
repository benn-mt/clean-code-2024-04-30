namespace CleanCode
{
    public class LengthUnit : Unit
    {
        public static readonly Unit INCH = new LengthUnit();
        public static readonly Unit FOOT = new LengthUnit(12, INCH);
        public static readonly Unit YARD = new LengthUnit(3, FOOT);
        public static readonly Unit FURLONG = new LengthUnit(220, YARD);
        public static readonly Unit MILE = new LengthUnit(8, FURLONG);

        public LengthUnit() : base()
        {
        }

        public LengthUnit(double ratioToReferenceUnit, Unit referenceUnit) : base(ratioToReferenceUnit, referenceUnit)
        {
        }
    }
}