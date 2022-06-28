namespace Laba5_dotnet;

public class WorkStation : IStructureComponent
{
    public WorkStation(decimal price)
    {
        Price = price;
    }

    public decimal Price { get; }
}