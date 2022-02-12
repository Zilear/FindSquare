using FindSquare.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSquare
{
    public class Triangle : IFigure
    {
        private double _aSide;
        private double _bSide;
        private double _cSide;
        /// <summary>
        /// public constructor, which creates a Triangle with certain sides
        /// </summary>
        /// <param name="aSide"></param>
        /// <param name="bSide"></param>
        /// <param name="cSide"></param>
        /// <exception cref="ArgumentException">returns an exception if one or more sides is negative or when a triangle with this values isn't exists</exception>
        public Triangle(double aSide, double bSide, double cSide)
        {
            if(aSide <= 0 || bSide <=0 || cSide <= 0)
                throw new ArgumentException("One or more sides is negative");
            if ((aSide > (bSide + cSide)) || (bSide > (cSide + aSide)) || (cSide > (aSide + bSide)))
                throw new ArgumentException("This triangle doesn't exist");
            _aSide = aSide;
            _bSide = bSide;
            _cSide = cSide;
        }
        /// <summary>
        /// function to know if this triangle is perpendicular
        /// </summary>
        /// <returns>bool value</returns>
        public bool IfNormal()
        {
            if (Math.Pow(_cSide, 2) == (Math.Pow(_aSide, 2) + Math.Pow(_bSide, 2))) return true;
            else if (Math.Pow(_aSide,2) == (Math.Pow(_bSide,2) + Math.Pow(_cSide,2))) return true;
            else if (Math.Pow(_bSide,2) == (Math.Pow(_aSide,2) + Math.Pow(_cSide,2))) return true;
            else return false;
        }
        /// <summary>
        /// function to get an area of a triangle
        /// </summary>
        /// <returns>Area of the Triangle</returns>
        public double GetArea()
        {
            if (IfNormal()) return _aSide * _bSide / 2;
            else
            {
                double p = (_aSide + _bSide + _cSide)/2;
                return Math.Sqrt(p*(p-_aSide)*(p-_bSide)*(p-_cSide));
            }
        }
    }
}
