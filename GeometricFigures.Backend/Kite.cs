using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigure.Backend
{
    internal class Kite : Rhombus
    {
        // Fields
        private double _b;


        //Properties
        public double B
        {
            get => _b;
            set => _b = ValidateB(value);
        }

        //Constructor method
        public Kite(string name, double d1, double d2, double a, double b) : base(name, d1, d2, a)
        {
            B = b;
        }

        //Public methods
        public override double GetArea()
        {
            return D1 * D2 / 2;
        }

        public override double GetPerimeter()
        {
            return 2 * (B + A);
        }

        //Private methods

        private double ValidateB(double b)
        {
            if (b >= 0)
            {
                return b;
            }
            else
            {
                throw new Exception($"The number of side {b} is a negative number ");
            }
        }

    }
}
