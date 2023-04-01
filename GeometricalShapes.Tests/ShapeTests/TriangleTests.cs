namespace GeometricalShapes.Tests.ShapeTests;

public class TriangleTests
{
    [Theory]
    [InlineData(3, 4, 5, 6)]
    [InlineData(6, 8, 10, 24)]
    [InlineData(8, 15, 17, 60)]
    public void ComputeArea_ReturnsCorrectArea(double a, double b, double c, double expectedArea)
    {
        var triangle = new Triangle(a, b, c);
        Assert.Equal(expectedArea, triangle.ComputeArea(), 1e-12);
    }

    [Theory]
    [InlineData(3, 4, 5, true)]
    [InlineData(5, 12, 13, true)]
    [InlineData(8, 15, 17, true)]
    [InlineData(6, 13, 11, false)]
    [InlineData(3, 7, 5, false)]
    [InlineData(5, 6, 7, false)]
    public void IsRight_ReturnsCorrectResult(double a, double b, double c, bool expectedResult)
    {
        var triangle = new Triangle(a, b, c);
        Assert.Equal(expectedResult, triangle.IsRight());
    }

    [Theory]
    [InlineData(3, 1, 1)]
    [InlineData(3, 4, 0)]
    [InlineData(1, 1, 3)]
    [InlineData(1, 3, 1)]
    [InlineData(5, 6, 12)]
    [InlineData(3, 4, 7)]
    [InlineData(6, 7, 15)]
    [InlineData(12, 16, 28)]
    public void Constructor_ThrowsArgumentExceptionOnInvalidSides(double a, double b, double c)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }
}