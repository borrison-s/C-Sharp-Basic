namespace HomeworkClass07.Models
{
    public class Rectangle : Shape
    {
        // Properties
        public int SideA { get; set; }
        public int SideB { get; set; }

        // Constructor
        public Rectangle(string name, string color, int[] position, int sideA, int sideB) : base(name, color, position)
        {
            SideA = sideA;
            SideB = sideB;
        }

        public override void GetArea()
        {
            int area = SideA * SideB;
            Console.WriteLine($"The area of the rectangle is {area}.");
        }

        public override void GetPerimeter()
        {
            double perimeter = 2 * (SideA + SideB);
            Console.WriteLine($"The perimeter of the rectanle is {perimeter}");
        }






    }
}
