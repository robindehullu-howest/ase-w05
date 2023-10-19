
List<int> randomNumbers = GenerateRandomNumbers(50);

Console.WriteLine("Random numbers: ");
Console.WriteLine(string.Join(", ", randomNumbers));

List<int> orderedNumbers = randomNumbers.OrderBy(x => x).ToList();

var evenNumbers =   from num in orderedNumbers
                    where num % 2 == 0
                    select num;

Console.WriteLine("Even numbers: ");
Console.WriteLine(string.Join(", ", evenNumbers));

var oddNumbers =    from num in orderedNumbers
                    where num % 2 != 0
                    select num;

Console.WriteLine("Odd numbers: ");
Console.WriteLine(string.Join(", ", oddNumbers));

var divisibleBy3 =  from num in orderedNumbers
                    where num % 3 == 0
                    select num;

Console.WriteLine("Numbers divisible by 3: ");
Console.WriteLine(string.Join(", ", divisibleBy3));

var divisibleBy3And5 =  from num in orderedNumbers
                        where num % 3 == 0 && num % 5 == 0
                        select num;

Console.WriteLine("Numbers divisible by 3 and 5: ");
Console.WriteLine(string.Join(", ", divisibleBy3And5));

var smallerThan30 = from num in orderedNumbers
                    where num < 30
                    select num;

Console.WriteLine("Numbers smaller than 30: ");
Console.WriteLine(string.Join(", ", smallerThan30));

var between20And30 = from num in orderedNumbers
                                    where num < 30 && num > 20
                                    select num;

Console.WriteLine("Numbers smaller than 30 and bigger than 20: ");
Console.WriteLine(string.Join(", ", between20And30));

var sumOfNumbersBetween20And30 = between20And30.Sum();

Console.WriteLine("Sum of numbers smaller than 30 and bigger than 20: ");
Console.WriteLine(sumOfNumbersBetween20And30);

var averageOfNumbersBetween20And30 = between20And30.Average();

Console.WriteLine("Average of numbers smaller than 30 and bigger than 20: ");
Console.WriteLine(averageOfNumbersBetween20And30);

var maxOfNumbersBetween20And30 = between20And30.Max();

Console.WriteLine("Max of numbers smaller than 30 and bigger than 20: ");
Console.WriteLine(maxOfNumbersBetween20And30);

var minOfNumbersBetween20And30 = between20And30.Min();

Console.WriteLine("Min of numbers smaller than 30 and bigger than 20: ");
Console.WriteLine(minOfNumbersBetween20And30);

var biggerThan20 = from num in orderedNumbers
                    where num > 20
                    select num;
var firstNumberBiggerThan20 = biggerThan20.First();

Console.WriteLine("First number bigger than 20: ");
Console.WriteLine(firstNumberBiggerThan20);

var add1ToEachNumber = orderedNumbers.Select(x => x + 1);

Console.WriteLine("Add 1 to each number: ");
Console.WriteLine(string.Join(", ", add1ToEachNumber));

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

