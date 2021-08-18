using HomeWorkGame.Abstract;
using HomeWorkGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkGame.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign has been added.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign has been deleted.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign has been updated.");
        }
    }
}
