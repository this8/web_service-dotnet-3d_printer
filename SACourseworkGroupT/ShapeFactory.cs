using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SACourseworkGroupT.Shapes;

namespace SACourseworkGroupT
{
    public class ShapeFactory
    {
        public IShape CreateShape(string name, double x, double y, double z)
        {
            if (name == "Circle")
            {
                return new Circle(x);
            }
            else if (name == "Rectangle")
            {
                return new Rectangle(x, y);
            }
            else if (name == "Triangle")
            {
                return new Triangle(x, y, z);
            }
            return null;
        }
    }
}