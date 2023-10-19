List<int> listA = new List<int> { 1, 2, 3, 4, 5 };
List<int> listB = new List<int> { 4, 5, 6, 7, 8 };

var result = listA.Intersect(listB).ToList();

foreach (var item in result)
{
    Console.WriteLine(item);
}