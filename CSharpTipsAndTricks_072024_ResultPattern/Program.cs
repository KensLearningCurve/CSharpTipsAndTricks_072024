using CSharpTipsAndTricks_072024.Logic;
using CSharpTipsAndTricks_072024_ResultPattern;

(Product? product, Result result) getProduct = GetProduct(0);

if (!getProduct.result.IsSuccess)
    Console.WriteLine(getProduct.result.Message);
else
    Console.WriteLine($"The product is {getProduct.product?.Title}");

static Result DeleteProduct(int id)
{
    if (id < 0)
        return Result.Failed($"The value of {nameof(id)} is invalid: {id}");

    Product ToDelete = ProductList.Products.Single(x => x.Id == id);
    ProductList.Products.Remove(ToDelete);

    return Result.Success();
}

static (Product?, Result) GetProduct(int id)
{
    if (id < 0)
        return (null, Result.Failed($"The value of {nameof(id)} is invalid: {id}"));

    Product product = ProductList.Products.Single(x => x.Id == id);
   
    return (product, Result.Success());
}