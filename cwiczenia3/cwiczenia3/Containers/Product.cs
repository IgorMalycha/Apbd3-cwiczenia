namespace cwiczenia3;

public class Product
{
    public string ProductsName { get; set; }
    public double Temperature { get; set; }

    public Product(string productsName, double temperature)
    {
        ProductsName = productsName;
        Temperature = temperature;
    }
}