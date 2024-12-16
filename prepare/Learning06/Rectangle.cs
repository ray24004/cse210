public class Rectangle : Shape
{
    public double _base;
    public double _height;

    public Rectangle(string color, double baseSize, double heightSize) : base(color)
    {
        _base = baseSize;
        _height = heightSize;
    }

    public override double GetArea()
    {
        return _base * _height;
    }
}