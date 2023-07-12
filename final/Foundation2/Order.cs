public class Order
{
    List<Product> _products;
    Customer _customer;

    public Order(string name, string street, string city, string state, string country)
    {
        _products = new List<Product>();
        _customer = new Customer(name, street, city, state, country);
    }

    public void AddProduct(string name, string productId, double price, int quantity)
    {
        Product product = new Product(name, productId, price, quantity);
        _products.Add(product);
    }

    public double CalculateOrderCost()
    {
        double subTotal = 0.00;
        double shippingFee = 35.00;

        if (_customer.InUnitedStates())
        {
            shippingFee = 5.00;
        }

        foreach (Product product in _products)
        {
            subTotal += product.GetPrice();
        }

        double total = Math.Round(subTotal + shippingFee, 2, MidpointRounding.AwayFromZero);

        return total;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing label:";

        foreach (Product product in _products)
        {
            packingLabel += $"\n{product.GetName()} - {product.GetProductId()}";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddressString()}";
    }
}
