//Take a sentence as input and print its words.
Console.WriteLine("=== Task two ===");
Console.WriteLine("Enter a sentence");
string sentence = Console.ReadLine();

string[] words = sentence.Split(" ");

foreach (string word in words)
{
    Console.WriteLine(word);
}