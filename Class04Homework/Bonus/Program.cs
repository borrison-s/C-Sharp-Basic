//##Bonus Take a sentence as input and print its largest word.
Console.WriteLine("=== Bonus ===");
Console.WriteLine("Enter a sentence");
string sentence = Console.ReadLine();
string[] words = sentence.Split(" ");
string longestWord = "";

foreach (string word in words)
{
    if (word.Length > longestWord.Length)
    {
        longestWord = word;
    }
}
Console.WriteLine($"The longest word in the sentence is: {longestWord}");