using HomeWorkGame.Abstract;
using HomeWorkGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkGame.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name + " has been added to DataBase.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + " has been updated.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " has been deleted.");
        }
    }
}
