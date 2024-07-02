using CSharpTipsAndTricks_072024.Logic;

int lastId = 6;
int productsPerPage = 10;

IEnumerable<Product> productsPage = ProductList.Products
    .Where(x=>x.Id > lastId)
    .Take(productsPerPage);

