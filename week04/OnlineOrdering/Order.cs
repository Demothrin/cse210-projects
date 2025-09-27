public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public float FinalCost()
    {
        float total = 0;

        foreach (var p in _products)
        {
            total += p.TotalCost();
        }
        total += ShippingPrice();
        return total;
    }
    public float ShippingPrice()
    {
        float price;
        if (_customer.LivesInAmerica())
        {
            price = 5;
        }
        else
        {
            price = 35;
        }
        return price;
    }
    public string PackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var p in _products)
        {
            label += " - " + p.GetProductInfo() + "\n";
        }
        return label;
    }
    public string ShippingLabel()
    {
        return $"Ship to:\n{_customer.GetName()}\n{_customer.GetAddress()}";
    }
}