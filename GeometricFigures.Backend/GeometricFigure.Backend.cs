namespace GeometricFigures.Backend
{
    public abstract class GeometricFigure
    {

        //Properties

        public string Name { get; }


        //Constructor method

        protected GeometricFigure(string name)
        {
            Name = name;
        }


        //Public methods


        public abstract double GetArea();


        public abstract double GetPerimeter();

        public override string ToString()
        {
            return $" {Name,-15} => Area.....: {GetArea(),15:N5}      Perimeter: {GetPerimeter(),15:N5}";
        }
    }

}
