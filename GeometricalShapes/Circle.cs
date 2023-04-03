namespace GeometricalShapes;

public class Circle : IShape
{
    /// <summary>
    /// Радиус
    /// </summary>
    public double Radius { get; }

    /// <summary>
    /// ctor
    /// </summary>
    public Circle(double radius)
    {
        if (radius <= 0) throw new ArgumentException("Радиус не может быть отрицательным или равен нулю");
        Radius = radius;
    }

    /// <inheritdoc/>
    public double ComputeArea() => Math.PI * Math.Pow(Radius, 2);
}