using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectGame
{
    interface ICampaignService
    {
        void Add(Campaign campaign , Game game);
        void Delete(Campaign campaign , Game game);
        void UpDate(Campaign campaign, Game game);
        
    }
}
