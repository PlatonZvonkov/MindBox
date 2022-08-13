using Shapes.Interfaces;
using System;

namespace Shapes
{
    public class Triangle : ITriangle
    {
        private readonly double sideA;
        private readonly double sideB;
        private readonly double sideC;      
          
        public bool IsRight { get => CheckTriangle(); }

        /// <summary>
        /// If you know all 3 sides of triangle
        /// </summary>
        /// <exception cref="ArgumentException">If sides are 0 or negative</exception>
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("One of the sides is not in correct fotmat");
            }
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;            
        }
                
        public double GetArea()
        { 
            return ByThreeSides();
        }

        private bool CheckTriangle()
        {          
           if(0 == Math.Pow(sideA, 2) + Math.Pow(sideB, 2) - Math.Pow(sideC, 2))
            {
                return true;
            }
            if (0 == Math.Pow(sideA, 2) + Math.Pow(sideC, 2) - Math.Pow(sideB, 2))
            {
                return true;
            }
            if (0 == Math.Pow(sideC, 2) + Math.Pow(sideB, 2) - Math.Pow(sideA, 2))
            {
                return true;
            }
            return false;
        }
            

        private double ByThreeSides()
        {
            double halfP = (sideA + sideB + sideC) / 2;
            return Math.Sqrt((halfP * (halfP - sideA) * (halfP - sideB) * (halfP - sideC)));
        }

    }
}
