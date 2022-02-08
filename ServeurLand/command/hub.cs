using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServeurLand.command
{
    public class hub
    {
        public static int Command(String commande)
        {
            switch (commande)
            {
                case ("RunMinecraft"):
                    Minecraft.Run();
                    return 0;
                default:
                    return 1;
            }

        }
    }
}
