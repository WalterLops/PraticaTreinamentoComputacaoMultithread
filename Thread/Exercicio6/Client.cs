using System.Net.Sockets;

namespace Exercicio6;

public static class Client
{
    public static void CreateNew(int id, string[] messages)
    {
        using TcpClient clientConnection = new TcpClient("127.0.0.1", 8089);
        using NetworkStream stream = clientConnection.GetStream();

        // ...
    }
}