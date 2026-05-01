using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sketche3dWPF.GeometryEngine
{
    public class Cuboid : Shape
    {
        private double mLength;
        private double mWidth;
        private double mHeight;

        public Cuboid(string name, double length, double width, double height) : base("cuboid", name)
        {
            this.mLength = length;
            this.mWidth = width;
            this.mHeight = height;
        }

        public double GetLength() { return mLength; }
        public double GetWidth() { return mWidth; }
        public double GetHeight() { return mHeight; }

        public override void save(StreamWriter sw)
        {
            sw.Write(GetType()); sw.Write(" ");
            sw.Write(GetName()); sw.Write(" ");
            sw.Write(GetLength()); sw.Write(" ");
            sw.Write(GetWidth()); sw.Write(" ");
            sw.Write(GetHeight());
        }
    }
}
