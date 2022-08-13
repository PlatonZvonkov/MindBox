using System;
using Xunit;
using Shapes.Interfaces;
using Shapes;
using Xunit.Abstractions;

namespace ShapesTests
{
    /// <summary>
    /// Unit tests for  Circle class: <see cref="Circle"/>
    /// </summary>
    public class CircleTests
    {
        private IShape shape;
        private ITestOutputHelper _output;
        public CircleTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void GivenIncorrectRadius_ThrowsException(double argument)
        {
            //Arrange, Act & Assert
            Assert.Throws<ArgumentException>(() => { shape = new Circle(argument); });
        }
        [Fact]
        public void GivenCorrectRadius_WorkingNormally()
        {
            //Arrange
            shape = new Circle(6);
            double expected = 113.09733552923255218;
            
            //Act 
            double actual = shape.GetArea(); 
            _output.WriteLine(actual.ToString());

            //Act
            Assert.True(actual == expected);
        }        
    }
}
