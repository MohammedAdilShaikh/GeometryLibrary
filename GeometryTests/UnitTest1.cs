using Xunit;
using GeometryLibrary;

namespace GeometryTests
{
    public class SquareTests
    {
        [Fact]
        public void TestSquareArea()
        {
            // Arrange
            var square = new Square(5);

            // Act
            var result = square.CalculateArea();

            // Assert
            Assert.Equal(25, result);
        }

        [Fact]
        public void TestSquarePerimeter()
        {
            // Arrange
            var square = new Square(5);

            // Act
            var result = square.CalculatePerimeter();

            // Assert
            Assert.Equal(20, result);
        }
    }

    public class RectangleTests
    {
        [Fact]
        public void TestRectangleArea()
        {
            // Arrange
            var rectangle = new Rectangle(4, 6);

            // Act
            var result = rectangle.CalculateArea();

            // Assert
            Assert.Equal(24, result);
        }

        [Fact]
        public void TestRectanglePerimeter()
        {
            // Arrange
            var rectangle = new Rectangle(4, 6);

            // Act
            var result = rectangle.CalculatePerimeter();

            // Assert
            Assert.Equal(20, result);
        }
    }

    public class TriangleTests
    {
        [Fact]
        public void TestTriangleArea()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            var result = triangle.CalculateArea();

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void TestTrianglePerimeter()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            var result = triangle.CalculatePerimeter();

            // Assert
            Assert.Equal(12, result);
        }
    }
}
