using HomeWorkGame.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkGame.Entities
{
    public class Player:IEntity
    {
        public int Id { get; set; }
        public long NationalityNo { get; set; } //Mernis sistemi long istediği için normalde string alınır.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
