using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SACourseworkGroupT.Shapes
{
    public class Rectangle : IShape
    {
        protected string name = "Rectangle";
        protected double length;
        protected double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public virtual string GetName()
        {
            return name;
        }

        public virtual double GetPerimeter()
        {
            return (length + width) * 2;
        }
    }
}