using BenchmarkDotNet.Attributes;
using CSharpTipsAndTricks_072024.Logic;
using System;
using System.Linq;

namespace CSharpTipsAndTricks_072024_ToLowerToUpperVSEquals;

public class Benchmarks
{
    [Benchmark]
    public void ToLower_Example()
    {
        Product product = ProductList.Products.First();
        string query = "7up";

        if (product.Title.ToLower() == query.ToLower())
            Console.WriteLine("This product is 7UP");
        else
            Console.WriteLine("This product is NOT 7Up");
    }

    [Benchmark]
    public void Equals_Example()
    {
        Product product = ProductList.Products.First();
        string query = "7up";

        if (string.Equals(product.Title, query, StringComparison.OrdinalIgnoreCase))
            Console.WriteLine("This product is 7UP");
        else
            Console.WriteLine("This product is NOT 7Up");
    }
}
