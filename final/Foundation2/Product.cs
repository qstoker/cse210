public class Product
{
    string _name;
    string _productId;
    double _price;
    int _quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public double GetPrice()
    {
        return _price * _quantity;
    }
}
