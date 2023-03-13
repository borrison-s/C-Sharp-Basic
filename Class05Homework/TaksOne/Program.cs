using System.Globalization;

int AgeCalculator(DateTime birthDate)
{
    DateTime today = DateTime.Today;
    int age = today.Year - birthDate.Year;

    // If the user hasn't had their birthday yet this year, subtract one from their age
    if (birthDate > today.AddYears(-age))
    {
        age--;
    }

    return age;
}
Console.WriteLine("Enter your birthdate (MM/dd/yyyy):");
string userInput = Console.ReadLine();
DateTime birthDate;
bool success = DateTime.TryParseExact(userInput, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out birthDate);

if (!success)
{
    Console.WriteLine("Invalid input. Please enter a valid date in the format MM/dd/yyyy");
}
else
{
    int age = AgeCalculator(birthDate);
    Console.WriteLine($"Your age is: {age}");
}


