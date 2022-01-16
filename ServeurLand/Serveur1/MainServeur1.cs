using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Sockets;
using System.Net;

namespace ServeurLand.Serveur1
{
    public class MainServeur1
    {
        public static void main()
        {
            try
            {
                int port = 9099;
                AsyncService service = new AsyncService(port);
                service.Run();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public class AsyncService
        {
            private IPAddress iPAdress;
            private int port;
            public AsyncService(int port)
            {
            }

            public async void Run()
            {
                TcpListener listener = new TcpListener(this.iPAdress, this.port);
                listener.Start();
                Console.WriteLine("Serveur up sur le port: " + this.port);
                while (true)
                {
                    try
                    {
                        TcpClient tcpClient = await listener.AcceptTcpClientAsync();
                        Task t = Process(tcpClient);
                        await t;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            private async Task Process(TcpClient tcp)
            {
                String ClientEndPoint = tcp.Client.RemoteEndPoint.ToString();
                Console.WriteLine("Connection request from " + ClientEndPoint);
            }
            private static string Response(String request)
            {

            }
            private static Average(double[] vals)
            {

            }
            private static double Minimum(double[] vals)
            {

            }
        }
    }
}
