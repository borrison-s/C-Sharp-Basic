Console.WriteLine("===Average Number===");

Console.WriteLine("Enter the first number!");
string inputOne = Console.ReadLine();

Console.WriteLine("Enter the second number!");
string inputTwo = Console.ReadLine();

Console.WriteLine("Enter the third number!");
string inputThree = Console.ReadLine();

Console.WriteLine("Enter the fourth number!");
string inputFour = Console.ReadLine();

int numberOne;
int numberTwo;
int numberThree;
int numberFour;
int avgNumber;

bool firstSuccess = int.TryParse(inputOne, out numberOne);
bool secondSuccess = int.TryParse(inputTwo, out numberTwo);
bool thirdSuccess = int.TryParse(inputThree, out numberThree);
bool fourthSuccess = int.TryParse(inputFour, out numberFour);

if(firstSuccess && secondSuccess && thirdSuccess && fourthSuccess)
{
    avgNumber = (numberOne + numberTwo + numberThree + numberFour) / 4;
}
else
{
    Console.WriteLine("One of the inputs is not valid");
    return;
}

Console.WriteLine("The average of " + numberOne + ", " + numberTwo + ", " + numberThree + " and " + numberFour + " is: " + avgNumber);
Console.WriteLine("Hello");