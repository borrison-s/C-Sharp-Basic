Console.WriteLine("=== Task two - Student Group ===");
string[] studentsG1 = new string[] { "Andrej", "Stefan", "Matej", "Ivan", "Aleksandar" };
string[] studentsG2 = new string[] { "Goran", "Damjan", "Anastasija", "Simona", "Andrea" };

Console.WriteLine("Enter student group: (There are 1 and 2)");
string userInput = Console.ReadLine();

int studentGroup;

bool success = int.TryParse(userInput, out studentGroup);

if (success)
{
    if (studentGroup != 1 && studentGroup != 2)
    {
        Console.WriteLine("Invalid input");
    }
    else if (studentGroup == 1)
    {
        foreach (string student in studentsG1)
        {
            Console.WriteLine(student);
        }
    }
    else if (studentGroup == 2)
    {
        foreach(string student in studentsG2)
        {
            Console.WriteLine(student);
        }
    }
}