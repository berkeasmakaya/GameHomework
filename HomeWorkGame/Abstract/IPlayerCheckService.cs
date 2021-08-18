using HomeWorkGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkGame.Abstract
{
    public interface IPlayerCheckService
    {
        bool CheckIfRealPlayer(Player player);
    }
}
