namespace Laba5_dotnet;


public class NetStructure : INetStructure
{
    private List<Server>? _servers;
    private List<Cable>? _cables;
    private List<WorkStation>? _workStations;

    public NetStructure(string name)
    {
        Name = name;
    }

    public string Name { get; set; }

    public List<Server>? Servers
    {
        get => _servers;
        set => _servers = value ?? throw new ArgumentNullException(nameof(value));
    }
    
    public List<Cable>? Cables
    {
        get => _cables;
        set => _cables = value ?? throw new ArgumentNullException(nameof(value));
    }

    public List<WorkStation>? WorkStations
    {
        get => _workStations;
        set => _workStations = value ?? throw new ArgumentNullException(nameof(value));
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}