using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigure.Backend
{
    internal class Rhombus : Square
    {
        // Fields
        private double _d1;
        private double _d2;

        //Properties
        public double D1
        {
            get => _d1;
            set => _d1 = ValidateD1(value);
        }

        public double D2
        {
            get => _d2;
            set => _d2 = ValidateD2(value);
        }

        //Constructor method
        public Rhombus(string name, double d1, double d2, double a) : base(name, a)
        {
            D1 = d1;
            D2 = d2;
        }

        //Public methods
        public override double GetArea()
        {
            return D1 * D2 / 2;
        }

        public override double GetPerimeter()
        {
            return 4 * A;
        }


        //Private methods

        private double ValidateD1(double d1)
        {
            if (d1 >= 0)
            {
                return d1;
            }
            else
            {
                throw new Exception($"The number of side {d1} is a negative number ");
            }
        }

        private double ValidateD2 (double d2)
        {
            if (d2 >= 0)
            {
                return d2;
            }
            else
            {
                throw new Exception($"The number of side {d2} is a negative number ");
            }
        }

    }







}



