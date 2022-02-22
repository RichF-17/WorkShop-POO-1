
using Workshop1;

public class Invoice : IPay
{
    private List<Products> _products;


    public Invoice()
    {
        _products = new List<Products>();
    }
    public Products AddProduct(Products product)
    {
        _products.Add(product);
        return product;
    }
    public decimal ValueToPay()
    {
        decimal value = 0;
        foreach (Products productscom in _products)
        {
            value += productscom.ValueToPay();
        }
        return value;
    }


    public override string ToString()
    {
        return $"\nRECEIPT" +
            $"\n------------------------------------" +
            $"\n\t {string.Join("\n", _products)}" +
            $"\n\t                     ==================" +
            $"\n\t TOTAL..............: {$"{ValueToPay():C2}",18}";

    }
}