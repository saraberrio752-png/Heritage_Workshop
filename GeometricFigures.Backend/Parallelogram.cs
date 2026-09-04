using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Backend
{
    public class Parallelogram : Rectangle
    {
        // Fields
        private double _h;

        //Properties
        public double H
        {
            get => _h;
            set => _h = ValidateH(value);
        }

        //Constructor method
        public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
        {
            H = h;
        }


        //Public methods
        public override double GetArea()
        {
            return H * B;
        }

        public override double GetPerimeter()
        {
            return 2 * (B + A);
        }

        //Private methods

        private double ValidateH(double h)
        {
            if (h >= 0)
            {
                return h;
            }
            else
            {
                throw new Exception($"The number of height {h} is a negative number ");
            }
        }
    }
}


