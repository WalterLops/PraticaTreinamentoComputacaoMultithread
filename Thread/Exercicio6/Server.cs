using System.Net;
using System.Net.Sockets;

namespace Exercicio6;

internal static class ServerClass
{
    private static TcpListener? _server;
    private static bool _running = true;
    public static void StartServer(int port)
    {
        _server = new TcpListener(IPAddress.Any, port);
        _server.Start();
        
        // ...
    }

    private static void HandleClient(TcpClient client)
    {
        if(client is null)
            throw new ArgumentException("Argumento clientObject não é um TcpClient", nameof(client));
        
        using NetworkStream stream = client.GetStream();
        byte[] buffer = new byte[1024];
        int bytesRead;

        // ...
    }

    public static void StopServer()
    {
        // ...
    }
}