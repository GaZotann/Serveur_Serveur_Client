using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ServeurLand.Serveur2
{
    public class MainServeur2
    {
        public static void mainServer2() //serveur d'écoute
        {
            Console.WriteLine("Démarrage du serveur 2");
            IPHostEntry ips = Dns.GetHostEntry(""); //on choppe l'adresse ip du DNS 
            Socket listener = new Socket(SocketType.Stream, ProtocolType.Tcp); //on créer un socket 

            //listener.Bind(new IPEndPoint(ips.AddressList[0], 9199)); //on dit à l'os d'accepter des requetes de connections
            listener.Bind(new IPEndPoint(IPAddress.IPv6Any, 9199));
            listener.Listen(5); // on laisse 5 écoutes avant de rejeter 

            byte[] lenbuf = new byte[sizeof(int)];
            
            while (true)
            {
                try
                {
                    using Socket request = listener.Accept(); // on accept la connection
                    int red = request.Receive(lenbuf);

                    if (red != lenbuf.Length)// on vérifie que les tailles sont bien les même
                        throw new Exception();

                    int messagelen = BitConverter.ToInt32(lenbuf);//on convertie la taille en int

                    byte[] buffer = new byte[messagelen]; //on créé un buffer de la bonne taille 

                    red = request.Receive(buffer);//on récupère le message

                    if (red != buffer.Length) //on vérifie les taille
                        throw new Exception();

                    String command = Encoding.UTF8.GetString(buffer);//on met ce qu'il y a dans le buffer dans un string 

                    //Todo command
                    Console.WriteLine($"J'ai recu: {command}");

                    request.Send(new byte[] { 0 });//on revoie 0 si tout s'est bien passé 

                }
                catch(Exception e)
                {
                    Console.WriteLine("ERROR");
                }
            }
        }
    }
}
