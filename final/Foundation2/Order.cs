class Order 
{

    private List<Product> _products;

    private Customer _customer;


    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }


     public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";

        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetName()} - {product.GetProductId()}\n";
        }

        return packingLabel;
    }


    public string ShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += $"Customer: {_customer.GetCustomerName()}\n";
        shippingLabel += $"Address: {_customer.GetAddress().GetFullAddress()}";

        return shippingLabel;
    }

    public double CalculateTotalPrice()
    {
        double total = 0;

        foreach(var product in _products)
        {
            total += product.ComputePrice();
        }


        return total;
    }

    public int ShippingCost()
    {
        if (_customer.CheckCountry())
        {
            return 5;
        }  
        else 
        {
            return 35;
        }
    }
}