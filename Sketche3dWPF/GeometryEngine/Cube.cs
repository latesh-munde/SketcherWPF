using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sketche3dWPF.GeometryEngine
{
    public class Cube : Shape
    {
        private double mSide;

        public Cube (string name, double side) : base("cube", name)
        {
            this.mSide = side;
        }

        public double GetSide() { return mSide; }

        public override void save(StreamWriter sw)
        {
            sw.Write(GetType()); sw.Write(" ");
            sw.Write(GetName()); sw.Write(" ");
            sw.Write(GetSide());
        }
    }
}
