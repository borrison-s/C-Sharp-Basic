List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

List<int> squares = numbers.Select(x => x * x).ToList();

foreach(int square in squares)
{
    Console.Write(square + " ");
}

