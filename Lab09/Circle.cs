namespace Lab09;

public class Circle : AbstractGraphic2D
{
    public override decimal LowerBoundX => -1;
    public override decimal UpperBoundX => -1;
    public override decimal LowerBoundY => -1;
    public override decimal UpperBoundY => -1;
    public decimal CenterX {get; private set;} = 1;
    public decimal CenterY {get; private set;} = 1;
    public decimal Radius {get; private set;} = 1;
    public Circle(decimal center_x, decimal center_y, decimal radius)
    {
        CenterX = center_x;
        CenterY = center_y;
        Radius = radius;
    }

    public override bool ContainsPoint(decimal x, decimal y)
    {
        return false;
    }
}