using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace MyWebServer
{
    class Program
    {
        public static async Task Main()
        {
            var address = IPAddress.Parse("127.0.0.1");
            var port = 8080;

            var serverListener = new TcpListener(address, port);

            serverListener.Start();

            Console.WriteLine($"Server started on port {port}...");
            Console.WriteLine("Listening for requests...");

            var connection = await serverListener.AcceptTcpClientAsync();

            connection.Close();
        }
    }
}
