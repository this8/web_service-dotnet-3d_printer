using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SACourseworkGroupT.Shapes;

namespace SACourseworkGroupT.Shapes
{
    public class ShapeFactory
    {
        public IShape CreateShape(string name, double x, double y, double z)
        {
            IShape shape = null;

            if (name.ToLower().Equals("circle"))
            {
                shape = new Circle(x);
            }
            else if (name.ToLower().Equals("rectangle"))
            {
                shape = new Rectangle(x, y);
            }
            else if (name.ToLower().Equals("triangle"))
            {
                shape = new Triangle(x, y, z);
            }
            return shape;
        }
    }
}