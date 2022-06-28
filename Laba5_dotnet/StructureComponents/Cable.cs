namespace Laba5_dotnet;

public class Cable : IStructureComponent
{
    public Cable(decimal price)
    {
        Price = price;
    }

    public decimal Price { get; }
    
}