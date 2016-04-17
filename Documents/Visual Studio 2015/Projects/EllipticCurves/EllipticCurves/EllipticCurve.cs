using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace EllipticCurves
{
    public class EllipticCurve
    {
        public BigInteger a;
        public BigInteger b;
        public BigInteger m;
        public EllipticCurve(BigInteger a, BigInteger b, BigInteger m)
        {
            if (4 * BigInteger.Pow(a, 3) + 27 * BigInteger.Pow(b, 2) != 0)
            {
                this.a = a;
                this.b = b;
                this.m = m;
            }
            else throw new Exception("Ошибка : нельзя использовать сингулярные кривые, т.е. такие, что 4*a^3 + 27*b^2 = 0 (mod m).\nПожалуйста, задайте верные коэффициенты.");
        }
        public bool Equals(EllipticCurve curveSecond)
        {
            return ((this.a == curveSecond.a) && (this.b == curveSecond.b) && (this.m == curveSecond.m));  
        } 
    }
}
