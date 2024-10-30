public class Rectangle : Shape
{
    private double _width;
    private double _height;

    // Constructor that accepts color, width, and height
    public Rectangle(string color, double width, double height) : base(color)
    {
        _width = width;
        _height = height;
    }

    // Override the GetArea method
    public override double GetArea()
    {
        return _width * _height;
    }
}