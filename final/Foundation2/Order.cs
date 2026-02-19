public class Order
{
    private Customer _customer;
    private List<Product> _myProducts = new List<Product>();
    private double _orderTotal;
    public Order()
    {
        
    }
    public Customer GetCustomer()
    {
        return _customer;
    }
    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }
    public double GetOrderTotal()
    {
        foreach (Product product in _myProducts)
        {
            double currentProductPrice = product.GetPriceTotal();
            _orderTotal = _orderTotal + currentProductPrice;
        }
        return _orderTotal;
    }
    public void DisplayOrder()
    {
        foreach (Product product in _myProducts)
        {
            Console.Write(product.GetQuantity() + " X " + product.GetName() + ", ");
            Console.WriteLine("$" + product.GetPricePerUnit());
        }
    }
    public void DisplayOrderTotal()
    {
        Console.WriteLine("$" + _orderTotal);
    }
    public void AddProduct(Product product)
    {
        _myProducts.Add(product); 
    }
    public void CheckCountry()
    {
        if(_customer.GetAddress().GetCountry() == "United States")
        {
            Console.WriteLine("Your shipping is $5.00");
            _orderTotal += 5;
        }
        else
        {
            Console.WriteLine("Your shipping is $35.00");
            _orderTotal +=35;
        }
    }
}