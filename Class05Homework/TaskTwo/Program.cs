using TaskTwo;

Console.WriteLine("Enter dog name: ");
string name = Console.ReadLine();

Console.WriteLine("Enter dog breed: ");
string breed = Console.ReadLine();

Console.WriteLine("Enter dog color: ");
string color = Console.ReadLine();

Dog dog = new Dog( name,  breed,  color)
{
    Name = name,
    Breed = breed,
    Color = color
};

Console.WriteLine($"Dog name: {dog.Name} Dog breed: {dog.Breed} Dog color: {dog.Color}");

Console.WriteLine("Chose an action for the dog: ");
Console.WriteLine("Enter 1. Eat");
Console.WriteLine("Enter 2. Play");
Console.WriteLine("Enter 3. Chase Tail");
string userInput = Console.ReadLine();

string message;
int choise;

bool success = int.TryParse(userInput, out choise);

if (!success)
{
    Console.WriteLine("Invalid input! Please enter: 1 for Eat, 2 for Play or 3 for Chase Tail");
}
else
{
    switch (choise)
    {
        case 1:
            message = dog.Eat();
            break;
        case 2:
            message = dog.Play();
            break;
        case 3:
            message = dog.ChaseTail();
            break;
        default:
            message = "Invalid choise!";
            break;
    }
    Console.WriteLine(message);
}
