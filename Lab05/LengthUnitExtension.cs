namespace Lab05;

public static class LengthUnitExtension
{
    public static double ToDouble(this LenghtUnit unit)
    {

        return unit switch
        {
            LenghtUnit.FOOT => 304.80,
            _ => (int)unit
        };
    }
    public static decimal ToDecimal(this LenghtUnit unit)
    {
        return unit switch
        {
            LenghtUnit.FOOT => (decimal)304.80,
            _ => (int)unit
        };
    }
}