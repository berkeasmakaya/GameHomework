using HomeWorkGame.Abstract;
using HomeWorkGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkGame.Concrete
{
    public class PlayerManager : PlayerBase
    {
        IPlayerCheckService _playerCheckService;

        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public override void Add(Player player)
        {
            if (_playerCheckService.CheckIfRealPlayer(player))
            {
                base.Add(player);
            }
            else
            {
                throw new Exception("Not a valid player.");
            }

        }


    }
}
