using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sketche3dWPF.GeometryEngine
{
    public abstract class Shape
    {
        private string mType;
        private string mName;

        public Shape(string type, string name)
        {
            this.mType = type;
            this.mName = name;
        }

        public string GetType() { return mType; }
        public string GetName() { return mName; }

        public abstract void save(StreamWriter sw);
        


    }
}
