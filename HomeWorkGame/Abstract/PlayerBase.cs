using HomeWorkGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkGame.Abstract
{
    public abstract class PlayerBase : IPlayerService
    {
        public virtual void Add(Player player)
        {
            Console.WriteLine(player.FirstName + " has been added.");
        }

        public void Delete(Player player)
        {
            Console.WriteLine(player.FirstName + " has been added.");
        }

        public void Update(Player player)
        {
            Console.WriteLine(player.FirstName + " has been added.");
        }
    }
}
