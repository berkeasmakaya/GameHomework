using HomeWorkGame.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkGame.Entities
{
    public class Campaign:IEntity
    {
        public int Id { get; set; }
        public int DiscountRate { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
