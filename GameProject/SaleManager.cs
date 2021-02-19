using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SaleManager : ISaleService
    {
        public void CampaignSale(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + " kullanıcısı " + campaign.CampaignName + " ile " + game.GameName + " oyununu aldı.");
        }
        public void Sale(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName + game.GameName+ "oyununu aldı");
        }
    }
}

