using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Backend
{
     public class Circle : GeometricFigure
    {
        // Fields
        private double _r;

        //Properties
        public double R
        {
            get => _r;
            set => _r = ValidateR(value);
        }

        //Constructor method
        public Circle(string name, double r) : base(name)
        {
            R = r;
        }

        //Public methods
        public override double GetArea()
        {
           return Math.PI * R * R;
        }

        public override double GetPerimeter()
        {
            return Math.PI * R * 2;
        }

        //Private methods

        private double ValidateR(double r)
        {
            if (r >= 0)
            {
                return r ;
            }
            else
            {
                throw new Exception($"The number of radio {r} is a negative number ");
            }
        }

    }

}
