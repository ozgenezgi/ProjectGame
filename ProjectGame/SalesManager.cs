using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectGame
{
    class SalesManager : IGameSales
    {
        public void Sales(Gamer gamer)
        {
            if (gamer.FirstName == "Ezgi")
            {
                Console.WriteLine("Oyunu satın aldınız.");
            }
            else
            {
                Console.WriteLine("satış olmadı.");
            }
        }
    }
}
