public abstract class Shape
{
    private string _color;

    // Constructor that accepts the color
    public Shape(string color)
    {
        _color = color;
    }

    // Getter for color
    public string GetColor()
    {
        return _color;
    }

    // Abstract method for area (to be overridden in derived classes)
    public abstract double GetArea();
}