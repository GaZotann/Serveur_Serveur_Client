using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace ServeurLand.Serveur1
{
    public class MainServeur1
    {
        public static void mainServer1(String commande) //serveur d'envoie 
        {
            Console.WriteLine("Démarrage du serveur 1");
            using Socket s = new Socket(SocketType.Stream, ProtocolType.Tcp);
            IPHostEntry ips = Dns.GetHostEntry("");
            while(true)
            {
                try
                {
                    //s.Connect(new IPEndPoint(ips.AddressList[0], 4242));
                    s.Connect(new IPEndPoint(IPAddress.IPv6Loopback, 9199));
                    byte[] msg = Encoding.UTF8.GetBytes(commande);
                    byte[] msgLen = BitConverter.GetBytes(msg.Length);
                    int sent = s.Send(msgLen);
                    if (sent != msgLen.Length)
                        throw new Exception("Erreur lenght");

                    sent = s.Send(msg);

                    if (sent != msg.Length)
                        throw new Exception("Erreur lenght");

                    byte[] resp = new byte[1];

                    int red = s.Receive(resp);

                    if (red != resp.Length)
                        throw new Exception("Erreur lenght");

                    if (resp[0] == 0)
                    {
                        Console.WriteLine("Command succes");
                        break;
                    }
                    else if (resp[0] == 1)
                    {
                        Console.WriteLine("Command succes");
                        break;
                    }
                    else
                        Console.WriteLine("Command error");

                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error {e}");
                }
                Thread.Sleep(10000);
            }  
        }
    }
}
