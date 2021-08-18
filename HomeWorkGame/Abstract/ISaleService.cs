using HomeWorkGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkGame.Abstract
{
    public interface ISaleService
    {
        void NormalSale(Player player, Game game);
        void BargainSale(Player player, Game game, Campaign campaign);
    }
}
