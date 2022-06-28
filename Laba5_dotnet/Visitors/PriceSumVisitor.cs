namespace Laba5_dotnet;


public class PriceSumVisitor : IVisitor
{
    public decimal Sum { get; private set; }
    
    public void Visit(NetStructure netStructure)
    {
        Sum = 0;
        if (netStructure.Cables != null)
        {
            foreach (var cable in netStructure.Cables)
            {
                Sum += cable.Price;
            }
        }
        if (netStructure.Servers != null)
        {
            foreach (var server in netStructure.Servers)
            {
                Sum += server.Price;
            }
        }
        if (netStructure.WorkStations != null)
        {
            foreach (var workStation in netStructure.WorkStations)
            {
                Sum += workStation.Price;
            }
        }
    }
}