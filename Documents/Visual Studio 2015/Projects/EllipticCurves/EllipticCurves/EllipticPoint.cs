using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace EllipticCurves
{
    public class EllipticPoint
    {
        BigInteger x;
        BigInteger y;
        EllipticCurve curve;
        public EllipticPoint(BigInteger x, BigInteger y, EllipticCurve curve)
        {
            this.x = x;
            this.y = y;
            this.curve = curve;
        }
        public bool Equals(EllipticPoint pointSecond)
        {
            return (this.curve.Equals(pointSecond.curve) && this.x == pointSecond.x && this.y == pointSecond.y);
        }
        public override string ToString()
        {
            return String.Format("x = {0}\ny = {1}\na = {2}\nb = {3}\nm = {4}", this.x, this.y, this.curve.a, this.curve.b, this.curve.m);
        }
        public static EllipticPoint operator +(EllipticPoint pointA, EllipticPoint pointB)
        {
            if (pointA.curve.Equals(pointB.curve))
            {
                BigInteger lambda, x, y;
                if (pointA.Equals(pointB))
                {
                    lambda = (3 * BigInteger.Pow(pointA.x, 2) + pointA.curve.a) / 2 * pointA.y;
                }
                else
                    lambda = (pointA.y - pointB.y) / (pointA.x - pointB.x);
                x = (BigInteger.Pow(lambda, 2) - pointA.x - pointB.x ) % pointA.curve.m;
                y = (lambda * (pointA.x - x) - pointA.y) % pointA.curve.m;
                return new EllipticPoint(x, y, pointA.curve);
            }
            else throw new Exception("Ошибка : cложение невозможно, т.к. точки постоены на разных кривых.");      
        }
        
    }
}
