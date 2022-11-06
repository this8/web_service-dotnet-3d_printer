using SACourseworkGroupT.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SACourseworkGroupT
{
    /// <summary>
    /// Summary description for PrinterService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class PrinterService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public double GetPerimeter(string name, double x, double y, double z)
        {
            ShapeFactory sf = new ShapeFactory();
            IShape shape;
            shape = sf.CreateShape(name, x, y, z);
            return sf.GetPerimeter(shape);
        }
    }
}
