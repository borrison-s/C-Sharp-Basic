using TaskTwo.Domain.Enums;
using TaskTwo.Domain.Models;

List<Animal> animals = new List<Animal>()
        {
            new Animal { Name = "Alex", Color = "Brown", Age = 5, Gender = Gender.Male },
            new Animal { Name = "Bella", Color = "Black", Age = 3, Gender = Gender.Female },
            new Animal { Name = "Charlie", Color = "White", Age = 7, Gender = Gender.Male },
            new Animal { Name = "Alice", Color = "Brown", Age = 4, Gender = Gender.Female },
            new Animal { Name = "Max", Color = "Brown", Age = 6, Gender = Gender.Male }
        };

Console.WriteLine("Animals aged 5 or more");

List<Animal> animalsAged5OrMore = animals.Where(x => x.Age >= 5).ToList();
List<string> animalNamesAged5OrMore = animalsAged5OrMore.Select(x => x.Name).ToList();
foreach(string animal in animalNamesAged5OrMore)
{
    Console.WriteLine(animal);
}

Console.WriteLine("Animals that starts with `A`");

List<Animal> animalThatStartsWithA = animals.Where(x => x.Name.StartsWith("A")).ToList();
List<string> animalNamesThatStartsWithA = animalThatStartsWithA.Select(x => x.Name).ToList();
foreach(string nameStartsWitha in animalNamesThatStartsWithA)
{
    Console.WriteLine(nameStartsWitha);
}

Console.WriteLine("All male, brown animals");

List<Animal> maleBrow = animals.Where(x => x.Gender == Gender.Male && x.Color == "Brown").ToList();
foreach(Animal maleBrownAnimal in maleBrow)
{
    Console.WriteLine(maleBrownAnimal.Name);
}

Console.WriteLine("First animal whose name is longer that 10 characters");

Animal firstWhosNameIsLongerThan10 = animals.FirstOrDefault(x => x.Name.Length > 10);

if (firstWhosNameIsLongerThan10 != null)
{
    Console.WriteLine("First animal with a name longer than 10 characters: " + firstWhosNameIsLongerThan10.Name);
}

