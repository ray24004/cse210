public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";

        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetPackingLabel()}\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return _customer.GetShippingLabel();
    }

    public float GetTotalPrice()
    {
        return _products.Sum(p => p.GetTotalPrice()) + GetShippingCost();
    }

    public float GetShippingCost()
    {
        return _customer.LivesInUSA() ? 5.00f : 35.00f;
    }
}