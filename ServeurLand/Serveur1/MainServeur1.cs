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
        public static void main() //serveur d'envoie 
        {
            using Socket s = new Socket(SocketType.Stream, ProtocolType.Tcp);

            try
            {

            }
            catch(Exception e)
            {
                Console.WriteLine("Error");
            }
        }
    }
}
