using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Diagnostics;

namespace EllipticCurves
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                //EllipticCurve ec = new EllipticCurve(BigInteger.Parse("-3"), BigInteger.Parse("2"), BigInteger.Parse("3"));
                EllipticCurve ec1 = new EllipticCurve(BigInteger.Parse("1"), BigInteger.Parse("2"), BigInteger.Parse("3"));
                EllipticCurve ec2 = new EllipticCurve(BigInteger.Parse("1"), BigInteger.Parse("2"), BigInteger.Parse("3"));

                EllipticPoint pointA = new EllipticPoint(BigInteger.Parse("3"), BigInteger.Parse("2"), ec1);
                EllipticPoint pointB = new EllipticPoint(BigInteger.Parse("3"), BigInteger.Parse("4"), ec2);
                Console.WriteLine((pointA + pointB).ToString());
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
