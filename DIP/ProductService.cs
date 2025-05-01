namespace DIP;
public class ProductService
{
    private readonly ILogger _logger;

    public ProductService(ILogger logger)
    {
        _logger = logger;
    }

    public void AddProduct(string name)
    {
        _logger.Log($"Product {name} added.");
    }
}