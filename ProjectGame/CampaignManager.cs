using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectGame
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign, Game game)
        {
            game.NewPrice = game.Price - 100;
            Console.WriteLine( "Yeni üyeliğiniz sonucunda " + game.GameName + "  İsimli oyuna yeni kampanya eklendi. Yeni fiyatı : " + game.NewPrice ); 
        }

        public void Delete(Campaign campaign, Game game)
        {
            Console.WriteLine("Kampanya çıkarıldı."); 
        }

        public void UpDate(Campaign campaign, Game game)
        {
            Console.WriteLine("Kampanya güncellendi.");
        }
    }
}
