namespace GeometricalShapes;

public class Triangle : IShape
{
    public double A { get; }
    public double B { get; }
    public double C { get; }
    
    /// <summary>
    /// Допустимая разница между сравниваемыми значениями
    /// </summary>
    private const double Tolerance = 1e-12;
    
    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0) 
            throw new ArgumentException("Строны треугольника не могут быть отрицательными");

        if (a + b <= c || a + c <= b || b + c <= a)
            throw new ArgumentException("Любые две стороны не могут быть больше третьей.");

        A = a;
        B = b;
        C = c;
    }

    /// <inheritdoc/>
    public double ComputeArea()
    {
        var s = (A + B + C) / 2;
        return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
    }
    
    /// <summary>
    /// Является ли треугольник правильным
    /// </summary>
    public bool IsRight()
    {
        var sides = new[] { A, B, C };
        Array.Sort(sides);
        return Math.Abs(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) < Tolerance;
    }
}