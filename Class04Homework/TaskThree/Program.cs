//Create a function that takes a number as input. This method should return the sum of the digits in the number.
Console.WriteLine("=== Task three ===");
Console.WriteLine("Enter a number: ");
string userInput = Console.ReadLine();
int number;
bool success = int.TryParse(userInput, out number);

if (success)
{
    int sum = SumOfDigits(number);
    Console.WriteLine($"The sum of the digits in {number} is {sum}");
}
else
{
    Console.WriteLine("Invalid input! Enter a valid number!");
}


int SumOfDigits(int number)
{
    int sum = 0;

    while (number != 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}





