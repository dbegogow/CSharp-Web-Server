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
            var port = 9090;

            var serverListener = new TcpListener(address, port);

            serverListener.Start();

            Console.WriteLine($"Server started on port {port}...");
            Console.WriteLine("Listening for requests...");

            var connection = await serverListener.AcceptTcpClientAsync();

            var networkStream = connection.GetStream();

            var content = "<h1>Здрасти от Джулио!</h1>";
            var contentLength = Encoding.UTF8.GetByteCount(content);

            var response = $@"HTTP/1.1 200 OK
Content-length: {contentLength}
Content-Type: text/html; charset=UTF-8

{content}";

            var responseBytes = Encoding.UTF8.GetBytes(response);

            await networkStream.WriteAsync(responseBytes);

            connection.Close();
        }
    }
}
