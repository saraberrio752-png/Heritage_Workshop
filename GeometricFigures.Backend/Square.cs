using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Backend
{
    public class Square : GeometricFigure
    {

        // Fields
        private double _a;


        //Properties
        public double A
        {
            get => _a;
            set => _a = ValidateA(value);
        }

        //Constructor method
        public Square (string name, double a) : base(name)
        {
            A = a;
        }

        //Public methods
        public override double GetArea()
        {
            return  A * A;
        }

        public override double GetPerimeter()
        {
            return 4 * A;
        }

        //Private methods

        private double ValidateA(double a)
        {
            if (a >= 0)
            {
                return a;
            }
            else
            {
                throw new Exception($"The number of side {a} is a negative number ");
            }
        }
    }
}
