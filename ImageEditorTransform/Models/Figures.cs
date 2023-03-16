using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ImageEditorTransform.Models
{
    [XmlInclude(typeof(LineElement))]
    [XmlInclude(typeof(PolylineElement))]
    [XmlInclude(typeof(PolygonElement))]
    [XmlInclude(typeof(RectangleElement))]
    [XmlInclude(typeof(EllipseElement))]
    [XmlInclude(typeof(PathElement))]
    public class Figures
    {
        private string name="";
        private string rotate="";
        private string scale = "";
        private string skew = "";
        private string center = "";

        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Rotate
        {
            get => rotate;
            set => rotate = value;
        }
        public string Scale
        {
            get => scale;
            set => scale = value;
        }
        public string Skew
        {
            get => skew;
            set => skew = value;
        }
        public string Center
        {
            get => center;
            set => center = value;
        }
    }
}
