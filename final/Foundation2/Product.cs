public class Product
{
    private string _name;
    private int _productID;
    private double _pricePerUnit;
    private int _quantity;
    
    public Product()
    {
        
    }
    public Product(string name, int productID, double pricePerUnit, int quantity)
    {
        _name = name;
        _productID = productID;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }
    public string GetName()
    {
        return _name;
    }
    public int GetProductID()
    {
        return _productID;
    }
    public double GetPricePerUnit()
    {
        return _pricePerUnit;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public double GetPriceTotal()
    {
        return _pricePerUnit * _quantity;
    }
}