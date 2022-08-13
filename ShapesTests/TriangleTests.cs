using System;
using Xunit;
using Shapes.Interfaces;
using Shapes;
using Xunit.Abstractions;

namespace ShapesTests
{
    /// <summary>
    /// Unit tests for Triancle class: <see cref="Triangle"/>
    /// </summary>
    public class TriangleTests
    {
        private ITriangle shape;
        private ITestOutputHelper _output;
        public TriangleTests(ITestOutputHelper output)
        {
            this._output = output;
        }

        [Theory]
        [InlineData(5,4,0)]
        [InlineData(5,4,-1)]
        public void GivenIncorrectSide_ThrowsException(double sideA,double sideB, double sideC)
        {
            //Arrange, Act & Assert
            Assert.Throws<ArgumentException>(() => { shape = new Triangle(sideA, sideB, sideC); });
        }

        [Fact]
        public void GivenCorrectSides_WorkingNormally()
        {
            //Arrange
            shape = new Triangle(5,4,3);
            double expected = 6;
            //Act 
            double actual = shape.GetArea();
            _output.WriteLine(actual.ToString());

            //Act
            Assert.True(actual == expected);
        }
        [Fact]
        public void GivenRightAngled_ShowsProperty()
        {
            //Arrange
            shape = new Triangle(5,4,3);

            //Act & Assert
            Assert.True(shape.IsRight);
        }
    }
}
