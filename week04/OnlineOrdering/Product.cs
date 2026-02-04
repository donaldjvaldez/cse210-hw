public class Product
{
    private string _productId;
    private string _productName;
    private double _price;
    private int _quantity;

    public Product(string productId, string productName, double price, int quantity) {
        _productId = productId;
        _productName = productName;
        _price = price;
        _quantity = quantity;
    }

    public string GetProductName() {
        return _productName;
    }
    
    public string GetProductId(){
        return _productId;
    }

    public double GetTotalCost() {
        return _price * _quantity;
    }

    public string GetPackingInfo() {
        return $"{_productName} (Product ID: {_productId}) -- Quantity: {_quantity}";
    }
}