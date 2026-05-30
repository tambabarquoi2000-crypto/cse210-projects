public class Product
{
    private  string _productName;
    private string _productID;
    private double _price;
    private int _quantity;

    public Product()
    {
        this._productName = "";
        this._productID = "";
        this._price = 0;
        this._quantity = 0;
    }

    public Product(string pName, string pID, double price, int qty)
    {
        this._productName = pName;
        this._productID =  pID;
        this._price = price;
        this._quantity = qty;

    }

    public double GetTotal()
    {
        return _price * _quantity;
    }

    public string GetProductNme()
    {
        return _productName;
    }

    public string GetProductID()
    {
        return _productID;
    }

}