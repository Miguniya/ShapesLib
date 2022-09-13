using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesLibrary;
using Assert = Xunit.Assert;
//using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TriangleTest()
        {
            Triangle rightTriangle = new Triangle(3, 4, 5);
            bool answer = rightTriangle.IsRightTriangle();
            // assert            
           Assert.Equal(true, answer);
        }

        [Fact]
        public void TriangleTest2()
        {
            Shape triangle = new Triangle(3, 4, 5);
            double sq = triangle.Square();
            // assert            
            Assert.Equal(6, sq);
        }
        [Fact]
        public void CircleTest()
        {
            Shape circle = new Circle(5);
            double sq = circle.Square();
            // assert            
            Assert.Equal(78.53981633974483, sq);
        }
    }
}