namespace GeometryUtils.Shapes
{
    public class Triangle : Shape
    {
        public double A { get; init; }
        public double B { get; init; }
        public double C { get; init; }
        public Triangle(double a, double b, double c)
        {
            if (!IsTriangleValid(a, b, c))
                throw new ArgumentException("Invalid triangle sides");
            A = a;
            B = b;
            C = c;
        }
        public override double CalculateArea()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
        private bool IsTriangleValid(double a, double b, double c)
        {
            return !(a + b < c || a + c < b || b + c < a ||
                a < 0 || b < 0 || c < 0);
        }
        public bool IsTriangleRight()
        {
            return (C * C == A * A + B * B || B * B == A * A + C * C || A * A == B * B + C * C);
        }
    }
}
