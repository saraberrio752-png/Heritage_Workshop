using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Backend
{
    public class Rectangle : Square
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
        public Rectangle(string name, double a, double b) : base(name, a)
        {
            B = b;
        }


        //Public methods
        public override double GetArea()
        {
            return A * B;
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