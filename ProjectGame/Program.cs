using System;

namespace ProjectGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new ValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                FirstName = "Ezgi",
                LastName = "özgen",
                IdentityNumber = 12345
            });
            CampaignManager campaignManager = new CampaignManager();
            SalesManager salesManager = new SalesManager();
            Campaign campaign1 = new Campaign();
            campaign1.Id = 2;
            campaign1.CampaignName = "Yeni üyelere özel";
            Game game1 = new Game();
            game1.GameName = "xyz";
            game1.Price = 150;
            game1.NewPrice = 0;
            campaignManager.Add(campaign1, game1);
            salesManager.Sales(new Gamer
            {
                Id = 1,
                FirstName = "Ezgi",
                LastName = "özgen",
                IdentityNumber = 12345
            });
        }
    }
}
