namespace HomeworkClass07.Models
{
    public class Shape
    {
        // Fields
        private string _name;
        private string _color;
        private int[] _position;

        // Properties
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Error: Name cannot be null or empty.");
                }
                else
                {
                    _name = value;
                    Console.WriteLine($"Name set to {_name}.");
                }
            }
        }

        public string Color
        {
            get { return _color; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Error: Color cannot be null or empty.");
                }
                else
                {
                    _color = value;
                    Console.WriteLine($"Color set to {_color}.");
                }
            }
        }

        public int[] Position
        {
            get { return _position; }
            set { _position = value; }
        }

        // Constructor
        public Shape(string name, string color, int[] position)
        {
            Name = name;
            Color = color;
            Position = position;
        }

        // Methods
        public virtual void GetArea()
        {
            Console.WriteLine("There is no special implementation for area.");
        }

        public virtual void GetPerimeter()
        {
            Console.WriteLine("There is no special implementation for perimeter.");
        }

        public static void Move(Shape shape)
        {
            int[] currentPosition = shape.Position;
            currentPosition[0] += 5;
            currentPosition[1] += 5;
            shape.Position = currentPosition;
        }
    }
}
