using HomeWorkGame.Abstract;
using HomeWorkGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkGame.Concrete
{
    public class SaleManager : ISaleService
    {
        public void BargainSale(Player player, Game game, Campaign campaign)
        {
            
            Console.WriteLine(player.FirstName + " bought game that is called " + game.Name + " at a discount.");
        }

        public void NormalSale(Player player, Game game)
        {
            Console.WriteLine(player.FirstName + " bought game that is called " + game.Name);
        }
    }
}
