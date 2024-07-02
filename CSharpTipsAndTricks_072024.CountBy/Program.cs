using CSharpTipsAndTricks_072024.Logic;

var availabilityCount = ProductList.Products
    .GroupBy(g => g.Available)
    .Select(x => new
    {
        Availability = x.Key,
        Count = x.Count()
    });

foreach (var availability in availabilityCount)
{
    Console.WriteLine($"{availability.Availability} => {availability.Count}");
}

Console.WriteLine(string.Empty);
Console.WriteLine("And now with the .NET 9 CountBy:");
Console.WriteLine(string.Empty);

IEnumerable<KeyValuePair<bool, int>> availabilityCountBy = ProductList.Products
    .CountBy(g => g.Available);

foreach (var availability in availabilityCountBy)
{
    Console.WriteLine($"{availability.Key} => {availability.Value}");
}
