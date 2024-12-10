public class Product
{
    private string _id;
    private string _name;
    private float _price;
    private int _quantity;
    public Product(string id, string name, float price, int quantity)
    {
        _id = id;
        _name = name;
        _price = price;
        _quantity = quantity;
    }

    public string GetPackingLabel()
    {
        return $"{_name} - {_id}";
    }

    public float GetTotalPrice()
    {
        return _price * _quantity;
    }
}