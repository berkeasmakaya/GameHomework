using HomeWorkGame.Adapters;
using HomeWorkGame.Concrete;
using HomeWorkGame.Entities;
using System;

namespace HomeWorkGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Id = 1;
            player.FirstName = "Berke";
            player.LastName = "Asmakaya";
            player.NationalityNo = 1234556789;
            player.DateOfBirth = new DateTime(2002,5,2);

            Player player2 = new Player();
            player2.Id = 2;
            player2.FirstName = "Osman";
            player2.LastName = "Yılmaz";
            player2.NationalityNo = 234567890;
            player2.DateOfBirth = new DateTime(2001,6,3);

            PlayerManager playerManager = new PlayerManager(new PlayerCheckManager());
            playerManager.Add(player);

            //PlayerManager playerManager2 = new PlayerManager(new MernisServiceAdapter());
            //playerManager2.Add(player2);

            Game game = new Game();
            game.Id = 1;
            game.Name = "Valorant";
            game.Price = 0;

            GameManager gameManager = new GameManager();
            gameManager.Add(game);

            Campaign campaign = new Campaign();
            campaign.Id = 1;
            campaign.DiscountRate = 15;
            campaign.StartingDate = new DateTime(2021, 11, 3);
            campaign.EndDate = new DateTime(2021, 11, 10);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);

            SaleManager saleManager = new SaleManager();
            saleManager.BargainSale(player, game, campaign);
        }
    }
}
