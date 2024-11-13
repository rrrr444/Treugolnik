using Xunit;
using Treugolnik;
using Assert = Xunit.Assert;

namespace Treugolnik
{
    public class TriangleTests
    {
        [Fact]
        public void TestEquilateralTriangle()
        {
            var (type, area) = Triangle.GetTriangleProperties(3, 3, 3);
            Assert.Equal("Равносторонний треугольник", type);
            Assert.Equal(3.897114317, area, 6); 
        }

        [Fact]
        public void TestIsoscelesTriangle()
        {
            var (type, area) = Triangle.GetTriangleProperties(3, 3, 4);
            Assert.Equal("Равнобедренный треугольник", type);
            Assert.Equal(4.799999999, area, 6); 
        }

        [Fact]
        public void TestScaleneTriangle()
        {
            var (type, area) = Triangle.GetTriangleProperties(3, 4, 5);
            Assert.Equal("Разносторонний треугольник", type);
            Assert.Equal(6, area, 6); 
        }

        [Fact]
        public void TestInvalidTriangleSides()
        {
            Assert.Throws<ArgumentException>(() => Triangle.GetTriangleProperties(1, 2, 3));
            Assert.Throws<ArgumentException>(() => Triangle.GetTriangleProperties(-1, 2, 2));
            Assert.Throws<ArgumentException>(() => Triangle.GetTriangleProperties(0, 1, 1));
        }
    }
}
