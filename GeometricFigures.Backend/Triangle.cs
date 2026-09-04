using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Backend
{
    public class Triangle : Rectangle
    {
        // Fields
        private double _c;

        private double _h;

        //Properties
        public double H
        {
            get => _h;
            set => _h = ValidateH(value);
        }

        public double C
        {
            get => _c;
            set => _c = ValidateC(value);
        }

        //Constructor method
        public Triangle(string name, double b, double a, double c, double h) : base(name, a, b)
        {
            C = c;
            H = h;
        }


        //Public methods
        public override double GetArea()
        {
            return (B * H) / 2;
        }

        public override double GetPerimeter()
        {
            return A + B + C;
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
                throw new Exception($"The number of side {h} is a negative number ");
            }
        }

        private double ValidateC(double c)
        {
            if (c >= 0)
            {
                return c;
            }
            else
            {
                throw new Exception($"The number of side {c} is a negative number ");
            }
        }

    }







}
