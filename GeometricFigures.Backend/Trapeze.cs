using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Backend
{
    public class Trapeze : Triangle
    {
        // Fields
        private double _d;


        //Properties
        public double D
        {
            get => _d;
            set => _d = ValidateD(value);
        }

        //Constructor method
        public Trapeze(string name, double a, double b, double c, double h, double d) : base(name, b, a, c, h)
        {
            D = d;
        }


        //Public methods
        public override double GetArea()
        {
            return ((B + D) * H / 2);
        }

        public override double GetPerimeter()
        {
            return D + A + B + C;
        }


        //Private methods

        private double ValidateD(double d)
        {
            if (d >= 0)
            {
                return d;
            }
            else
            {
                throw new Exception($"The number of side {d} is a negative number ");
            }
        }
    }

}
