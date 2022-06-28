namespace Laba5_dotnet;

public class Server : IStructureComponent
{
    public decimal Price { get; }

    public Server(decimal price)
    {
        Price = price;
    }
}