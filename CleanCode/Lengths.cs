namespace CleanCode
{
    public static class Lengths
    {
        public static readonly Unit INCH = new Unit();
        public static readonly Unit FOOT = new Unit(12, INCH);
        public static readonly Unit YARD = new Unit(3, FOOT);
        public static readonly Unit FURLONG = new Unit(220, YARD);
        public static readonly Unit MILE = new Unit(8, FURLONG);
    }
}