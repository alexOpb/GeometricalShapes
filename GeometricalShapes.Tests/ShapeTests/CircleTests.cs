namespace GeometricalShapes.Tests.ShapeTests;

public class CircleTests
{
    [Theory]
    [InlineData(5, 78.5398163397448)]
    [InlineData(10, 314.159265358979)]
    [InlineData(2.5, 19.6349540849362)]
    public void ComputeArea_ReturnsCorrectArea(double radius, double expectedArea)
    {
        var circle = new Circle(radius);
        Assert.Equal(expectedArea, circle.ComputeArea(), 1e-12);
    }
    
    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    public void Constructor_ThrowsArgumentExceptionOnInvalidRadius(double radius)
    {
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }
}