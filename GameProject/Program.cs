using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //GamerManager gamerManager = new GamerManager(new UserValidationManager());
            //gamerManager.Add(new Gamer
            //{
            //  Id = 1,
            //  BirthYear = 1985,
            //  FirstName = "sena",
            //  LastName = "bilgin",
            //  IdentityNumber = 12345

            //});
            GamerManager gamerManager1 = new GamerManager(new UserValidationManager());
            Gamer gamer1 = new Gamer() { Id = 1, BirthYear = 1999, FirstName = "Sena", LastName = "Bilgin", IdentityNumber = 1231231231 };
            GamerManager gamerManager2 = new GamerManager(new UserValidationManager());
            Gamer gamer2 = new Gamer() { Id = 2, BirthYear = 1999, FirstName = "Mirem", LastName = "Işıldak", IdentityNumber = 1231231232 };

            Game game1 = new Game() { Id = 5, GameName = "Oyun1", GamePrice = 35 };
            Game game2 = new Game() { Id = 6, GameName = "Oyun2", GamePrice = 30 };
            Game game3 = new Game() { Id = 7, GameName = "Oyun3", GamePrice = 120 };


            Campaign campaign1 = new Campaign() { CampaignName = "A Kampanyası"};
            Campaign campaign2 = new Campaign() { CampaignName = "B Kampanyası" };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);
            campaignManager.Update(campaign1);
            campaignManager.Update(campaign2);
            campaignManager.Delete(campaign1);
            campaignManager.Delete(campaign2);

            SaleManager salesManager = new SaleManager();
            salesManager.CampaignSale(game3, gamer2, campaign1);




        }
    }
}
