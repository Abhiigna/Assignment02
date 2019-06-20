using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public class TriangleSolver
    {
        public static string Analyze(int line1, int line2, int line3)
        {
            int Sidea = line1 + line2;
            int Sideb = line2 + line3;
            int Sidec = line1 + line3;

            String msg = "";
            if (Sidea > line3 && Sideb > line1 && Sidec > line2)
            {
                if ((line1 == line2) && (line1 == line3))
                    return msg += "Equilateral Triangle";
                else if ((line1 == line2) || (line2 == line3) || (line1 == line3))
                    return msg += "Isosceles Triangle";
                else return msg += "Scalene Triangle";
            }
            else if (line1 < 0 || line2 < 0 || line3 < 0) { return msg += "invalid Input"; }
            else return msg += "Triangle incorrect formed";
        }

    }
}
