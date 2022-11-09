using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SACourseworkGroupT.Shapes
{
    public class Circle : IShape
    {
        // protected string name = "Circle";
        protected double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        // public virtual string GetName()
        // {
        //     return name;
        // }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}