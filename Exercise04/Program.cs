List<string> cities = new List<string>
{
    "London",
    "Paris",
    "Milan",
    "New York",
    "Los Angeles"
};

Console.WriteLine("Cities:");
Console.WriteLine(string.Join(", ", cities));

var citiesStartingWithL = from city in cities
                              where city.StartsWith("L")
                              orderby city
                              select city;

Console.WriteLine("Cities starting with L:");
Console.WriteLine(string.Join(", ", citiesStartingWithL));

var citiesStartingWithLAndEndingWithN = from city in cities
                                         where city.StartsWith("L") && city.EndsWith("n")
                                         orderby city
                                         select city;

Console.WriteLine("Cities starting with L and ending with n:");
Console.WriteLine(string.Join(", ", citiesStartingWithLAndEndingWithN));

var citiesWithLengthOf6 = from city in cities
                             where city.Length == 6
                             orderby city
                             select city;

Console.WriteLine("Cities with length of 6:");
Console.WriteLine(string.Join(", ", citiesWithLengthOf6));

