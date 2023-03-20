using HomeworkClass07.Models;

int[] rectPosition = { 0, 0 };
Rectangle rect = new Rectangle("MyRectangle", "Red", rectPosition, 5, 10);
rect.GetArea(); // output: The area of the rectangle is 50.
rect.GetPerimeter(); // output: The perimeter of the rectangle is 30.

int[] circlePosition = { 1, 1 };
Circle circle = new Circle("MyCircle", "Blue", circlePosition, 3);
circle.GetArea(); // output: The area of the circle is: 28.274333882308138
circle.GetPerimeter(); // output: The perimeter of the circle is: 18.84955592153876

// Test the Move method
Console.WriteLine($"Initial position of rectangle: {rect.Position[0]}, {rect.Position[1]}");
Shape.Move(rect);
Console.WriteLine($"New position of rectangle: {rect.Position[0]}, {rect.Position[1]}");

Console.WriteLine($"Initial position of circle: {circle.Position[0]}, {circle.Position[1]}");
Shape.Move(circle);
Console.WriteLine($"New position of circle: {circle.Position[0]}, {circle.Position[1]}");
