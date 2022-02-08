using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ServeurLand.Serveur1;
using ServeurLand.Serveur2;
using System.Collections.Generic;
using System.Linq;

namespace ServeurLand
{
    class Program
    {
        static void Main(string[] args)
        {
            int mode;
            //mode = Int32.Parse(Console.ReadLine());
            mode = Int32.Parse(args[0]);

            String commande = String.Join("", args[1]);
            switch (mode)
            {
                case 1:
                    Task.Run(
                        MainServeur2.mainServer2
                    );
                    MainServeur1.mainServer1(commande); 
                    break;
                case 2:
                    MainServeur2.mainServer2();
                    break;
                default:
                    Console.WriteLine("Il faut mettre 1 ou 2... Fin du programme");
                    return;
            }
        }
    }
}
