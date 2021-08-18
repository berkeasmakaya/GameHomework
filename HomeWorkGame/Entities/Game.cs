using HomeWorkGame.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkGame.Entities
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
