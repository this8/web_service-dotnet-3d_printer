using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SACourseworkGroupT.Shapes
{
    public class Triangle : IShape
    {
        protected string name = "Triangle";
        protected double lengthOfSide1;
        protected double lengthOfSide2;
        protected double lengthOfSide3;

        public Triangle(double l1, double l2, double l3)
        {
            this.lengthOfSide1 = l1;
            this.lengthOfSide2 = l2;
            this.lengthOfSide3 = l3;
        }

        public string GetName()
        {
            return name;
        }

        public double GetPerimeter()
        {
            return lengthOfSide1 + lengthOfSide2 + lengthOfSide3;
        }
    }
}