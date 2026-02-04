public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer) {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product) {
        _products.Add(product);
    }

    public double GetTotalCost() {
        double total = 0;
        foreach (Product product in _products)
        {
         total += product.GetTotalCost();   
        }
        total += _customer.LivesInUSA() ? 5 : 35;
        return total;
    }
    public string GetPackingLabel() {
        string label = "\nPacking Label:\n";
        foreach (Product product in _products)
        {
         label += $"{product.GetProductName()} (Product ID: {product.GetProductId()})";   
        }
        return label;
    }
    public string GetShippingLabel() {
        return $"Shipping to:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}\n";
    }
}