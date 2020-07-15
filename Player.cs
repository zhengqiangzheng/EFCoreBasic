using System;
using System.Collections.Generic;

namespace Demo.Domain
{
    public class Player
    {
        public Player()
        {
            gamePlayers = new List<GamePlayer>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<GamePlayer> gamePlayers { get; set; }
        public int ResumeId { get; set; }
        public Resume Resume { get; set; }

    }
}