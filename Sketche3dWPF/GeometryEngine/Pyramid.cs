using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sketche3dWPF.GeometryEngine
{
    public class Pyramid: Shape
    {
        private double mBaseLength;
        private double mBaseWidth;
        private double mHeight;

        public Pyramid(string name, double length, double width, double height) : base("pyramid", name)
        {
            this.mBaseLength = length;
            this.mBaseWidth = width;
            this.mHeight = height;
        }

        public double GetLength() { return mBaseLength; }
        public double GetWidth() { return mBaseWidth; }
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
