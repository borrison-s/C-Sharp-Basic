Console.WriteLine("===Swap Numbers===");

Console.Write("Input the First Number: ");
string firstInput = Console.ReadLine();

Console.Write("Input the Second Number: ");
string secondInput = Console.ReadLine();

int firstNumber;
int secondNumber;

bool firstSuccess = int.TryParse(firstInput, out firstNumber);
bool secondSuccess = int.TryParse(secondInput, out secondNumber);

if(firstSuccess && secondSuccess)
{
    Console.WriteLine("Before swapping:");
    Console.WriteLine("First number: " + firstNumber);
    Console.WriteLine("Second number: " + secondNumber);

    int tempValue = firstNumber; //Keeps the value of first number
    firstNumber = secondNumber;
    secondNumber = tempValue;

    Console.WriteLine("After swapping:");
    Console.WriteLine("First number: " + firstNumber);
    Console.WriteLine("Second number: " + secondNumber);
}
else
{
    Console.WriteLine("One of the inputs is incorrect!");
}


