// Creating an empty Queue
Queue<int> numbersQueue = new Queue<int>();
string userInput = "";
do
{
    // Give the user an option to input numbers
    Console.Write("Enter a number: ");
    userInput = Console.ReadLine();
    int number;
    if (int.TryParse(userInput, out number))
    {
        numbersQueue.Enqueue(number);
        Console.Write("Do you want to enter another number? (Y/N): ");
        userInput = Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid integer number.");
    }
} 
// As long as user inputs "Y" he`ll be given to enter another number that will be stored in the Queue
while (userInput.ToUpper() == "Y");

// If the user enter something different 
Console.WriteLine("\nThe numbers you entered are:");
while (numbersQueue.Count > 0)
{
    Console.WriteLine(numbersQueue.Dequeue());
}

