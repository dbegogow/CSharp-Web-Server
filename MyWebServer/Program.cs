using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
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

            var networkStream = connection.GetStream();

            var response = @"HTTP/1.1 200 OK

Hello from the server!";

            var responseBytes = Encoding.UTF8.GetBytes(response);

            connection.Close();
        }
    }
}
