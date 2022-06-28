namespace Laba5_dotnet;

public interface INetStructure
{
    string Name { get; set; }
    public List<Server>? Servers { get; set; }
    public List<Cable>? Cables { get; set; }
    public List<WorkStation>? WorkStations { get; set; }
    void Accept(IVisitor visitor);
}