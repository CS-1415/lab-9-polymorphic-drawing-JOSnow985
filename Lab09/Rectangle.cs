namespace Lab09;

public class Rectangle : AbstractGraphic2D
{
    public override decimal LowerBoundX => -1;
    public override decimal UpperBoundX => -1;
    public override decimal LowerBoundY => -1;
    public override decimal UpperBoundY => -1;
    public decimal Left {get; private set;} = 0;
    public decimal Top {get; private set;} = 0;
    public decimal Width {get; private set;} = 1;
    public decimal Height {get; private set;} = 1;
    
    public Rectangle(decimal left, decimal top, decimal width, decimal height)
    {
        Left = left;
        Top = top;
        Width = width;
        Height = height;
    }

    public override bool ContainsPoint(decimal x, decimal y)
    {
        return false;
    }
}