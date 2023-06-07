namespace GeometryUtils.Shapes
{
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("invalid circle radius");
            Radius = radius;
        }
        public double Radius { get; init; }
        public override double CalculateArea() => Math.PI * Radius * Radius;
    }
}
