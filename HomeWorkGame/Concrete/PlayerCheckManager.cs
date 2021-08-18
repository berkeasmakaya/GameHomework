using HomeWorkGame.Abstract;
using HomeWorkGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkGame.Concrete
{
    public class PlayerCheckManager : IPlayerCheckService
    {
        public bool CheckIfRealPlayer(Player player)
        {          
            return true;
        }
    }
}
