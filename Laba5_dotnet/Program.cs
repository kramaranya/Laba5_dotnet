namespace Laba5_dotnet;

class Program
{
    public static void Main()
    {
        List<Server> servers = new List<Server>
        {
            new Server(1000), new Server(1000), new Server(500)
        };
        
        List<Cable> cables = new List<Cable>
        {
            new Cable(10), new Cable(10), new Cable(30)
        };
        
        List<WorkStation> workStations = new List<WorkStation>
        {
            new WorkStation(2000), new WorkStation(3000), new WorkStation(5000)
        };

        NetStructure netStructure = new NetStructure("Structure")
        {
            Servers = servers,
            Cables = cables,
            WorkStations = workStations
        };

        var visitor = new PriceSumVisitor();
        netStructure.Accept(visitor);

        Console.WriteLine($"Price of '{netStructure.Name}' equals {visitor.Sum}.");
        Console.ReadLine();
    }
}