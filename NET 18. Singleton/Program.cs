// Singleton
// https://refactoring.guru/ru/design-patterns/singleton

Connection connection;
connection = Connection.GetConnection("172.0.0.1", 4043);
Console.WriteLine(connection);
connection = Connection.GetConnection("192.0.0.1", 456);
Console.WriteLine(connection);

class Connection
{
    public string IpAddress { get; private set; }
    public int Port { get; private set; }
    private static Connection _connection;
    private Connection(string iPAddress, int port)
    {
        IpAddress = iPAddress;
        Port = port;
    }

    static public Connection GetConnection(string IpAddress, int port)
    {
        if (_connection is null)
        {
            _connection = new Connection(IpAddress, port);
        }
        return _connection;
    }
    public override string ToString()
    {
        return $"{IpAddress}: {Port}";
    }
}
