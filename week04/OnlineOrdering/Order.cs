public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();



    public Order(Customer customer)
    {
        this._customer = customer;
        this._products = new List<Product>();
    }

    public void AddToCart(Product product)
    {
        _products.Add(product);
    }

    public double ClcTotalCost()
    {
        double totalCost = 0;
        double shipCost = _customer.IsInUSA()? 5 : 35;

        foreach(Product product in _products)
        {
            totalCost += product.GetTotal();
        }

        return totalCost + shipCost;
    }

    public string GetPackagingLabel()
    {
        string packagingLabel = "";
        foreach(Product product in _products)
        {
            packagingLabel += $"{product.GetProductID()}: {product.GetProductNme()}\n";
        }

        return packagingLabel.Trim();
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetCustomerName()}\n{_customer.Address().GetFullAddress()}";
        
    }
}