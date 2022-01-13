using System;
using ServeurLand.Serveur1;
using ServeurLand.Serveur2;

namespace ServeurLand
{
    class Program
    {
        static void Main(string[] args)
        {
            int mode;
            Console.WriteLine("Tapez 1 pour le serveur1, tapez 2 pour le serveur2: ");
            mode = Int32.Parse(Console.ReadLine());
            switch (mode)
            {
                case 1:
                    Console.WriteLine("Démarrage du serveur 1");
                    MainServeur1.main();
                    break;
                case 2:
                    Console.WriteLine("Démarrage du serveur 2");
                    MainServeur2.main();
                    break;
                default:
                    Console.WriteLine("Il faut mettre 1 ou 2... Fin du programme");
                    return;
            }
        }
    }
}
