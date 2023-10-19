Random random = new Random();
List<int> randomNumbers = new List<int>();
for (int i = 0; i < 10; i++)
{
    randomNumbers.Add(random.Next(1, 100));
}

List<int> randomNumbers2 = new List<int>();
for (int i = 0; i < 10; i++)
{
    randomNumbers2.Add(random.Next(1, 100));
}

var mergedList = randomNumbers.Union(randomNumbers2);

foreach (var item in mergedList)
{
    Console.WriteLine(item);
}
