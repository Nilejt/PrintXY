using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintXY
{
    public class Point
    
    {
        public int X {get; set;}

        public int Y {get; set;}

        public double Distance
        {
            get { return Math.Sqrt(X * X + Y * Y); }
        }
        



        public override string ToString()
        {
            return string.Format("({0}, {1}) is {2} from the origin", X, Y, Distance);
        }
    }
}
