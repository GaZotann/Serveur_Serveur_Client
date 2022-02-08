using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServeurLand.command
{
    public class Minecraft
    {
        public static void Run()
        {
            Console.WriteLine("Run minecraft");
            Process proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "./serveurs/minecraft_paper/serveur.sh",
                    UseShellExecute = true
                }
            };
            proc.Start();
        }
    }
}
