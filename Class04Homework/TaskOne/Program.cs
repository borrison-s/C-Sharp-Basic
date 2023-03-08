//Take one string from the input and print its last 5 characters.

Console.WriteLine("=== Task one ===");
Console.WriteLine("Enter a string: ");
string userInput = Console.ReadLine();
string lastFiveCharacters;

if (userInput.Length >= 5)
{
    lastFiveCharacters = userInput.Substring(userInput.Length - 5);
}
else
{
    lastFiveCharacters = userInput;
}

Console.WriteLine($"The last five characters are: {lastFiveCharacters}");