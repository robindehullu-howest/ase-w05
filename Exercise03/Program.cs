
List<int> randomNumbers = GenerateRandomNumbers(50);

List<int> orderedNumbers = randomNumbers.OrderBy(x => x).ToList();





List<int> GenerateRandomNumbers(int count)
{
    Random random = new Random();
    List<int> numbers = new List<int>();
    for (int i = 0; i < count; i++)
    {
        numbers.Add(random.Next(1, 100)); // Adjust the range as needed
    }
    return numbers;
}

