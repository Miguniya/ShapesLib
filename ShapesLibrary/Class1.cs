namespace ShapesLibrary
{
    public abstract class Shape
    {
        public abstract double Square();
    }

    public class Circle : Shape
    {
        double Rad = 0.0;
        public Circle(double rad)
        {
            this.Rad = rad;
        }
        public override double Square()
        {
            double square = Math.Pow(Rad, 2) * Math.PI;
            return square;
        }
    }

    public class Triangle : Shape
    {
        double SideA = 0.0;
        double SideB = 0.0;
        double SideC = 0.0;
        public Triangle(double sideA, double sideB, double sideC)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
        }
        public override double Square()
        {
            double semiP = (SideA + SideB + SideC) / 2;
            double square = Math.Sqrt(semiP * (semiP - SideA) * (semiP - SideB) * (semiP - SideC));
            return square;
        }

        public bool IsRightTriangle()
        {
            double[] sides = new Double[] { SideA, SideB, SideC };
            Array.Sort(sides);
            return (sides[0]* sides[0] + sides[1]* sides[1] == sides[2]* sides[2]);
        }
    }
}