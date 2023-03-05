Console.WriteLine("===Real Calculator!===");

Console.WriteLine("Enter number one!");
string firstInput = Console.ReadLine();

Console.WriteLine("Enter number Two!");
string secondInput = Console.ReadLine();

Console.WriteLine("Enter the operation (+, -, *, /)");
string operators = Console.ReadLine();

int firstNumber;
int secondNumber;

bool firstSuccess = int.TryParse(firstInput, out firstNumber);
bool secondSuccess = int.TryParse(secondInput, out secondNumber);

if(firstSuccess && secondSuccess)
{
    double result = 0;

    switch (operators)
    {
        case "+":
            result = firstNumber + secondNumber;
            break;
        case "-":
            result = firstNumber - secondNumber;
            break;
        case "*":
            result = firstNumber * secondNumber;
            break;
        case "/":
            if(secondNumber == 0)
            {
                Console.WriteLine("Cannot divide by zero");
                return;
            }
            result = firstNumber / (double)secondNumber;
            break;
        default:
            Console.WriteLine("Invalid operator");
            return;
    }
    Console.WriteLine("The result is: " + result);
}
else
{
    Console.WriteLine("Invalid input. Please enter valid numbers");
}

