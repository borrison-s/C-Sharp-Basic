namespace HomeworkClass07.Models
{
    public class Circle : Shape
    {
        // Properties
        public double Radius { get; set; }

        public Circle(string name, string color, int[] position, double radius) : base(name, color, position)
        {
            Radius = radius;
        }

        public override void GetArea()
        {
            double area = Math.PI * Math.Pow(Radius, 2);
            Console.WriteLine($"The area of the circle is: {area}");
        }

        public override void GetPerimeter()
        {
            double perimeter = 2 * Math.PI * Radius;
            Console.WriteLine($"The perimeter of the circle is: {perimeter}");

        }
    }
}
