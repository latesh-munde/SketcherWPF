using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sketche3dWPF.GeometryEngine
{
    public class Sphere : Shape
    {
        private double mRadius;

        public Sphere(string name, double radius, double height): base("sphere", name)
        {
            this.mRadius = radius;
        }

        public double GetRadius() { return mRadius; }

        public override void save(StreamWriter sw)
        {
            sw.Write(GetType()); sw.Write(" ");
            sw.Write(GetName()); sw.Write(" ");
            sw.Write(GetRadius()); 
        }
    }
}
