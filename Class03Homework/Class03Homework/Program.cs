Console.WriteLine("=== Task one - Sum of even ===");
int[] numbersArray = new int[] { 4, 3, 7, 3, 2, 8 };

int sum = 0;

foreach (int number in numbersArray)
{
    if (number % 2 == 0)
    {
        sum += number;
    }
}
Console.WriteLine("The result is: " +  sum);