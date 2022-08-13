using Shapes.Interfaces;
using System;

namespace Shapes
{
    public class Circle : IShape
    {
        public readonly double radius;
        private const double pi = Math.PI;

        /// <summary>
        /// Create circle if you know radius
        /// </summary> 
        /// <param name="radius">radius</param>
        /// <exception cref="ArgumentException">if diameter is negative or 0</exception>
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                 throw new ArgumentException("Radius can not be 0 or negative number!");
            }
               
            this.radius = radius;
        }
        
        public double GetArea()
        {
            return Math.Pow(radius, 2) * pi;
        }
    }
}
