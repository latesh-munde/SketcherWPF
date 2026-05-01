using System.IO;

namespace Sketche3dWPF.GeometryEngine
{
    public class Point
    {
        private double mX;
        private double mY;
        private double mZ;

        public Point()
        {
            this.mX = 0;
            this.mY = 0;
            this.mZ = 0;
        }

        public Point(double mX, double mY, double mZ)
        {
            this.mX = mX;
            this.mY = mY;
            this.mZ = mZ;
        }

        public double Distance(Point other)
        {
            return Math.Sqrt((mX - other.mX) * (mX - other.mX) +
                             (mY - other.mY) * (mY - other.mY) +
                             (mZ - other.mZ) * (mZ - other.mZ));
              
        }

        public double GetX() { return mX; }
        public double GetY() { return mY; }
        public double GetZ() { return mZ; }

        public void SetX(double x) { mX = x; }
        public void SetY(double y) { mY = y; }
        public void SetZ(double z) { mZ = z; }

        public void WriteXYZ(StreamWriter sw)
        {
            sw.Write(mX);sw.Write(" ");
            sw.Write(mY);sw.Write(" ");
            sw.Write(mZ);
        }

        const double tol = 1e-6; //tolerance
        public static bool operator==(Point p1, Point p2)
        {
            return ((p1.mX - p2.mX) < tol && 
                    (p1.mY - p2.mY) < tol && 
                    (p1.mZ - p2.mZ) < tol);
        }

        public static bool operator !=(Point p1, Point p2)
        {
            return ((p1.mX - p2.mX) > tol ||
                    (p1.mY - p2.mY) > tol ||
                    (p1.mZ - p2.mZ) > tol);
        }

        public bool IsEqual(Point p2)
        {
            return ((mX - p2.mX) < tol &&
                    (mY - p2.mY) < tol &&
                    (mZ - p2.mZ) < tol);
        }
    }
}
