using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sketche3dWPF.GeometryEngine
{
    public class Cone : Shape
    {
        private double mRadius;
        private double mHeight;

        public Cone(string name, double radius, double height): base("cone", name)
        {
            this.mRadius = radius;
            this.mHeight = height;
        }

        public double GetRadius() { return mRadius; }
        public double GetHeight() { return mHeight; }

        public override void save(StreamWriter sw)
        {
            sw.Write(GetType()); sw.Write(" ");
            sw.Write(GetName()); sw.Write(" ");
            sw.Write(GetRadius()); sw.Write(" ");
            sw.Write(GetHeight());
        }
    }
}
