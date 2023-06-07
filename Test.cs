using GeometryUtils.Shapes;
using Xunit;

public class GeometryUtilsTests
{
    public class TriangleTests
    {
        [Fact]
        public void CalculateArea_Triangle_ValidTriangle_ReturnsCorrectArea()
        {
            // Arrange
            Triangle triangle = new Triangle(3, 4, 5);
            double expectedArea = 6;
            // Act
            double actualArea = triangle.CalculateArea();
            // Assert
            Assert.Equal(expectedArea, actualArea);
        }
        [Fact]
        public void IsTriangleRight_Triangle_RightTriangle_ReturnsTrue()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            bool isRightTriangle = triangle.IsTriangleRight();
            Assert.True(isRightTriangle);
        }
        [Fact]
        public void Triangle_InvalidSides_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, -3));
        }
    }
    public class CircleTests 
    {

        [Fact]
        public void CalculateArea_Circle_ValidCircle_ReturnsCorrectArea()
        {
            Circle circle = new Circle(2);
            double expectedArea = Math.PI * 4;
            double actualArea = circle.CalculateArea();
            Assert.Equal(expectedArea, actualArea);
        }
        [Fact]
        public void Circle_InvalidRadius_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }
    }
    private class FakeShape : Shape
    {
        public override double CalculateArea()
        {
            return 10; // Фиктивное значение площади для тестирования
        }
    }

    [Fact]
    public void CalculateArea_Shape_ReturnsCorrectArea()
    {
        Shape shape = new FakeShape();
        double expectedArea = 10; 
        double actualArea = GeometryUtils.Utils.GeometryCalculator.CalculateArea(shape);
        Assert.Equal(expectedArea, actualArea);
    }
}
